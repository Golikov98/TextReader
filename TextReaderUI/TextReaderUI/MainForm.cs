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

        private void DeletePunctuationMarkButton_Click(object sender, EventArgs e)
        {
            //Переводим строку из файла в массив элементов 
            char[] symbolsArray = text.FileText.ToCharArray();

            //Записываем массив элементов в список List
            var symbolsList = new List<char>(symbolsArray);

            text.SymbolMark = DeletePunctuationMarkTextBox.Text.ToCharArray();
            //text.SymbolMark = symbol;

            for (var i = 0; i < symbolsList.Count; i++)
            {
                //Записываем в массив символ, введенный в DeletePunctuationMarkTextBox
                //char[] symbol = text.SymbolMark.ToCharArray();

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

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, text.FileText);
            }
        }
    }
}
