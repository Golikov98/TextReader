﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReader
{
    /// <summary>
    /// Класс Text, содержащий поля _fileText, _symbolMark
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
