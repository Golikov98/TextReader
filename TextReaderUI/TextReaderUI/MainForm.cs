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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                text.FileText = File.ReadAllText(fileName);
                FileTextTextBox.Text = text.FileText;
            }
        }

        //Кнопка, удаляющая знак препинания из текста файла
        private void DeletePunctuationMarkButton_Click(object sender, EventArgs e)
        {
            DeletePunctuationSymbolMethod();
        }

        //Кнопка, вызывающая SaveFileDialog
        private void SaveFileButton_Click(object sender, EventArgs e)
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

        //Метод, удаляющий знак препинания из текста файла
        private void DeletePunctuationSymbolMethod()
        {
            //Переводим строку из файла в массив элементов 
            char[] symbolsArray = text.FileText.ToCharArray();

            //Записываем массив элементов в список List
            var symbolsList = new List<char>(symbolsArray);

            text.SymbolMark = DeletePunctuationMarkTextBox.Text.ToCharArray();

            for (var i = 0; i < symbolsList.Count; i++)
            {
                //Если элемент списка symbolsList равен символу массива symbol
                if (symbolsList[i] == text.SymbolMark[0])
                {
                    //Удаляем элемент списка
                    symbolsList.RemoveAt(i);
                }
            }

            //Преобразуем список symbolsList в строку fileText
            text.FileText = String.Join("", symbolsList);

            //Выводим строку fileText в FileTextTextBox
            FileTextTextBox.Text = text.FileText;

            //Очищаем DeletePunctuationMarkTextBox
            DeletePunctuationMarkTextBox.Clear();
        }

        private void DeleteWordsSpecifiedLength()
        {
            //Записываем в text.FileText данные из FileTextTextBox
            text.FileText = FileTextTextBox.Text;

            //Записываем в переменную LengthDeleteWords содержимое DeleteWordsLengthTextBox
            string LengthDeleteWords = DeleteWordsLengthTextBox.Text;

            //Считываем данные из строки и переводим в тип int
            var currentLength = int.Parse(LengthDeleteWords);

            // Передаем данные из переменной currentLength в text.MinWordLength
            text.MinWordLength = currentLength;

            //Разделяем строку на подстроки по пробелу и записываем полученные подстроки в массив строк words
            string[] words = text.FileText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Записываем массив строк в список wordsList
            var wordsList = new List<string>(words);

            for (int i=0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Length < text.MinWordLength)
                {
                    wordsList.RemoveAt(i);
                }
                else if (wordsList[i].Length >= text.MinWordLength)
                {
                    i++;
                }
            }

            //Преобразуем список wordsList в строку fileText
            text.FileText = String.Join(" ", wordsList);

            //Выводим строку fileText в FileTextTextBox
            FileTextTextBox.Text = text.FileText;
        }

        private void DeleteLongerWordButton_Click(object sender, EventArgs e)
        {
            DeleteWordsSpecifiedLength();
        }
    }
}
