using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReader
{
    /// <summary>
    /// Класс Text, содержащий поля _fileText, _symbolMark, _minWordLength.
    /// </summary>
    public class Text
    {
        private string _fileText;

        public string FileText
        {
            get
            {
                return _fileText;
            }
            set
            {
                _fileText = value;
            }
        }

        private char[] _symbolMark;

        public char[] SymbolMark
        {
            get
            {
                return _symbolMark;
            }
            set
            {
                _symbolMark = value;
                
                if (SymbolMark[0] == '.')
                {
                    _symbolMark = SymbolMark;
                }
                else if(SymbolMark[1] == ',')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[2] == ':')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[3] == '-')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[4] == '*')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[5] == '{')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[6] == '}')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[7] == '(')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[8] == ')')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[9] == ';')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[10] == '?')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[11] == '#')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[12] == '@')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[13] == '/')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[14] == '&')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[15] == '~')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[16] == '<')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[17] == '>')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[18] == '[')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[19] == ']')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[20] == '"')
                {
                    _symbolMark = SymbolMark;
                }
                else if (SymbolMark[21] == '!')
                {
                    _symbolMark = SymbolMark;
                }
                else{ throw new ArgumentException("Неверное значение!"); }

            }

        }
        private int _minWordLength;

        public int MinWordLength
        {
            get
            {
                return _minWordLength;
            }
            set
            {
                _minWordLength = value;
            }
        }
    }
}
