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

namespace TextReaderUI
{
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

            for (int i=0; i < wordsList.Count; i++)
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                FileName = fileName;
                text.FileText = File.ReadAllText(fileName);
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

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMethod();
        }

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

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileMethod();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save result?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
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
    }
}
