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

namespace TextReaderUI
{
    public partial class EditTextForm : Form
    {
        public Text currentText = new Text();
        char[] DeleteSymbolsMark = new char[22];

        public EditTextForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (this.DialogResult == DialogResult.OK)
            {
                Text text = new Text();

                text.SymbolMark = DeleteSymbolsMark;
                currentText.SymbolMark = DeleteSymbolsMark;

                string MinimumLength = MinimumWordLengthTextBox.Text;
                try
                {
                    text.MinWordLength = int.Parse(MinimumLength);
                    currentText.MinWordLength = int.Parse(MinimumLength);
                }
                catch { }
            }
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FullStopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[0] = '.';
            }
        }

        private void CommaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[1] = ',';
            }
        }

        private void ColonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[2] = ':';
            }
        }

        private void HyphenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[3] = '-';
            }
        }

        private void AsteriskCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[4] = '*';
            }
        }

        private void BraceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[5] = '{';
                DeleteSymbolsMark[6] = '}';
            }
        }

        private void ParenthesisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[7] = '(';
                DeleteSymbolsMark[8] = ')';
            }
        }

        private void SemiColonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[9] = ';';
            }
        }

        private void QuestionMarkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[10] = '?';
            }
        }

        private void HashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[11] = '#';
            }
        }

        private void AtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[12] = '@';
            }
        }

        private void VirguleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[13] = '/';
            }
        }

        private void AmpersandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[14] = '&';
            }
        }

        private void TildeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[15] = '~';
            }
        }

        private void AngleBracketCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[16] = '<';
                DeleteSymbolsMark[17] = '>';
            }
        }

        private void SquareBrecketCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[18] = '[';
                DeleteSymbolsMark[19] = ']';
            }
        }

        private void QuotationMarkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[20] = '"';
            }
        }

        private void ExclamationMarkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                DeleteSymbolsMark[21] = '!';
            }
        }

        private void EditTextForm_Load(object sender, EventArgs e)
        {

        }
    }
}
