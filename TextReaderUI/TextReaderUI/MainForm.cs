using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextReader;
using System.IO;
using System.Threading;

namespace TextReaderUI
{
    /// <summary>
    /// Главная форма взаимодействия с пользователем MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        Text text = new Text();
        string FileName;
        char[] DeleteSymbolArray = new char[22];
        int currentMinimumLength;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Кнопка, вызывающая OpenFileDialog
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileMethod();
        }

        //Кнопка, вызывающая SaveFileDialog
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileMethod();
        }

        //Метод, удаляющий знак препинания из текста файла
        private void DeletePunctuationSymbolMethod()
        {
            //Передаем содержимое FileTextTextBox в text.FileText
            text.FileText = FileTextTextBox.Text;

            //Переводим строку из файла в массив элементов 
            char[] symbolsArray = FileTextTextBox.Text.ToCharArray();

            //Записываем массив элементов в список List
            var symbolsList = new List<char>(symbolsArray);

            for (int i = 0; i < symbolsList.Count; i++)
            {
                for (int j = 0; j < DeleteSymbolArray.Length; j++)
                {
                    //Если элемент списка symbolsList равен символу массива DeleteSymbolArray
                    if (symbolsList[i] == DeleteSymbolArray[j])
                    {
                        //Удаляем элемент списка
                        symbolsList.RemoveAt(i);

                        i = 0;
                    }
                }
            }

            //Преобразуем список symbolsList в строку fileText
            text.FileText = String.Join("", symbolsList);

            //Выводим строку fileText в FileTextTextBox
            FileTextTextBox.Text = text.FileText;
        }

        //Метод, удаляющий слова меньше заданной длины
        private void DeleteWordsSpecifiedLength()
        {
            //Записываем в text.FileText данные из FileTextTextBox
            text.FileText = FileTextTextBox.Text;

            //Разделяем строку на подстроки по пробелу и записываем полученные подстроки в массив строк words
            string[] words = text.FileText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Записываем массив строк в список wordsList
            var wordsList = new List<string>(words);

            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Length <= currentMinimumLength)
                {
                    wordsList.RemoveAt(i);
                    i = 0;
                }

                if (wordsList[i].Length <= currentMinimumLength)
                {
                    wordsList.RemoveAt(i);
                }
            }

            //Преобразуем список wordsList в строку fileText
            text.FileText = String.Join(" ", wordsList);

            //Выводим строку fileText в FileTextTextBox
            FileTextTextBox.Text = text.FileText;
        }

        //Метод, открывающий указанный пользователем файл
        private void OpenFileMethod()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Если диалог завершился с результатом ОК
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Записываем в строку адрес файла
                string fileName = openFileDialog.FileName;

                //Записываем адрес в глобальную переменную
                FileName = fileName;

                //Передаем текст файла в проект бизнес-логики
                text.FileText = File.ReadAllText(fileName);

                //Выводим на пользовательскую форму текст файла
                FileTextTextBox.Text = text.FileText;
            }
        }

        //Метод, сохраняющий данные в указанный пользователем файл
        private void SaveFileMethod()
        {
            //Присваеваем FileText данные из FileTextTextBox
            text.FileText = FileTextTextBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Указываем формат файла, в который будут сохраняться данные
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, text.FileText);
            }

            //Очищаем FileTextTextBox
            FileTextTextBox.Clear();
        }

        //Поле для открытия файла
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMethod();
        }

        //Поле для сохранение текста по изначально открытому адресу
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileMethod();
            }
            else
            {
                //Присваеваем FileText данные из FileTextTextBox
                text.FileText = FileTextTextBox.Text;

                File.WriteAllText(FileName, text.FileText);
            }
        }

        //Поле для сохранения текста в выбранный пользователем файл
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileMethod();
        }

        //Поле выхода из приложения
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Выводим сообщение о сохранении результата
            DialogResult result = MessageBox.Show("Save result?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                //Если сохранение текста происходит не из открытого файла, то вызываем диалог для сохранения/создания файла
                if (FileName == null)
                {
                    //Вызов метода
                    SaveFileMethod();
                }
                else
                {
                    //Присваеваем FileText данные из FileTextTextBox
                    text.FileText = FileTextTextBox.Text;

                    File.WriteAllText(FileName, text.FileText);
                }
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        //Кнопка для вывода формы редактирования текста
        private void EditTextButton_Click(object sender, EventArgs e)
        {
            var EditTextForm = new EditTextForm();
            EditTextForm.ShowDialog();
            if (EditTextForm.DialogResult == DialogResult.OK)
            {
                DeleteSymbolArray = EditTextForm.currentText.SymbolMark;
                DeletePunctuationSymbolMethod();

                currentMinimumLength = EditTextForm.currentText.MinWordLength;
                DeleteWordsSpecifiedLength();
            }
        }

        //Метод, обеспечивающий обработку паки с файлами
        private void ProcessFolderFilesMethod()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            //Если результат диалога выбора папки равен ОК
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Записываем в переменную путь к выбранно папке
                string folderName = folderBrowserDialog.SelectedPath;

                //Записываем в массив пути к файлам в указанной папке
                string[] folderFiles = Directory.GetFiles(folderName, "*.txt", SearchOption.AllDirectories);

                //Выводим пользователю диалог с запросом на необходимость обработки файлов в указанной папке
                DialogResult result = MessageBox.Show("Process a files in folder?", "Process", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    var editTextForm = new EditTextForm();
                    editTextForm.ShowDialog();

                    if (editTextForm.DialogResult == DialogResult.OK)
                    { 
                        DeleteSymbolArray = editTextForm.currentText.SymbolMark;
                        currentMinimumLength = editTextForm.currentText.MinWordLength;

                        //Выводим пользователю сообщение о необходимости сохранения файлов в папке
                        DialogResult SaveFilesInFolder = MessageBox.Show("Save files in folder?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (SaveFilesInFolder == DialogResult.OK)
                        {
                            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                            {
                                //Записываем в переменную путь к выбранной для сохранения папке
                                string folderSaveName = folderBrowserDialog.SelectedPath;

                                //Циклом проходим по всем файла в выбранной папке
                                for (var i = 0; i < folderFiles.Length; i++)
                                {
                                    //Получаем имя файла, с которым программа работает в данный момент
                                    string folderSaveNameInFolder = Path.GetFileName(folderFiles[i]);

                                    //Получаем текст из файла, с которым программа взаимодействует в данный момент
                                    string fileTextInFolder = File.ReadAllText(folderFiles[i]);

                                    //Записываем в массив элементов текст из файла
                                    char[] symbolsArray = fileTextInFolder.ToCharArray();

                                    //Записываем массив с текстом из файла в список 
                                    var symbolsList = new List<char>(symbolsArray);

                                    //Циклом проходим по всем элементам списка
                                    for (int z = 0; z < symbolsList.Count; z++)
                                    {
                                        //Циклом проходим по всем элементам массива со знаками, которые необходимо удалить из текста
                                        for (int j = 0; j < DeleteSymbolArray.Length; j++)
                                        {
                                            //Если элемент списка symbolsList равен символу массива DeleteSymbolArray
                                            if (symbolsList[z] == DeleteSymbolArray[j])
                                            {
                                                //Удаляем элемент списка
                                                symbolsList.RemoveAt(z);

                                                //Обнуляем счетчик для удаления для контрольной проверки текста
                                                z = 0;
                                            }
                                        }
                                    }

                                    //Записываем в строку результат обработки списка
                                    fileTextInFolder = String.Join("", symbolsList); 
                                    
                                    //Записываем в строковый массив строки, полученные при разделении входящей строки по пробелу
                                    string[] words = fileTextInFolder.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                                    //Записываем в список массив строк
                                    var wordsList = new List<string>(words);

                                    //Циклом проходим по всем элементам списка
                                    for (int q = 0; q < wordsList.Count; q++)
                                    {
                                        //Если длина элемента списка меньше либо равна минимальной заданной длине
                                        if (wordsList[q].Length <= currentMinimumLength)
                                        {
                                            //Удаляем элемент списка
                                            wordsList.RemoveAt(q);

                                            //Обнуляем счетчик
                                            q = 0;
                                        }

                                        //Повторяем операцию для устранения необработанных элементов списка, 
                                        //если находим, то удаляем элемент
                                        if (wordsList[q].Length <= currentMinimumLength)
                                        {
                                            //Удаляем элемент списка
                                            wordsList.RemoveAt(q);
                                        }
                                    }

                                    //Преобразуем список в строку, вставляя между элементами списка пробел
                                    fileTextInFolder = String.Join(" ", wordsList);

                                    //Комбинируем путь до папки и имя сохраняемого файла в один путь
                                    var file = Path.Combine(folderSaveName, folderSaveNameInFolder);

                                    //Записываем по указанному пути файл с редактированным текстом
                                    File.WriteAllText(file, fileTextInFolder);                               
                                }

                                //Выводим сообщения об окончании обработки папки
                                DialogResult completed = MessageBox.Show("Process completed!", "Complet", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        //Поле обработки папки с файлами
        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessFolderFilesMethod();
        }

        //Поле редактирования текста файла 
        private void EditTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var EditTextForm = new EditTextForm();

            //Вызываем форму для выбора действий по редактированию текста файла
            EditTextForm.ShowDialog();

            //Если результат работы формы ОК
            if (EditTextForm.DialogResult == DialogResult.OK)
            {
                //Передаем массив со знаками препинания, которые необходимо удалить в MainForm из EditTextForm
                DeleteSymbolArray = EditTextForm.currentText.SymbolMark;

                DeletePunctuationSymbolMethod();

                //Передаем минимальную длину слова в MainForm из EditTextForm
                currentMinimumLength = EditTextForm.currentText.MinWordLength;

                DeleteWordsSpecifiedLength();
            }
        }
    }
}
