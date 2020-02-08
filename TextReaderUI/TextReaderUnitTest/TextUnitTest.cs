using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TextReader;

namespace TextReaderUnitTest
{
    [TestFixture]
    public class TextUnitTest
    {
        [Test(Description ="Позитивный тест геттера FileText")]
        public void TestFileTextGet_CorrectValue()
        {
            var expected = "Текст файла";
            var text = new Text();
            text.FileText = expected;
            var actual = text.FileText;

            Assert.AreEqual(expected, actual, "Геттер FileText возвращает неверный текст.");
        }

        [Test(Description = "Позитивный тест геттера SymbolMark")]
        public void TestSymbolMarkGet_CorrectValue()
        {
            char[] symbolMarkTest = new char[] { '.', ',', ':', ';' };
            var expected = symbolMarkTest;
            var text = new Text();
            text.SymbolMark = expected;
            var actual = text.SymbolMark;

            Assert.AreEqual(expected, actual, "Геттер SymbolMark возвращает неверный массив.");
        }

        [Test(Description = "Присвоение неверного символа в массив элементов.")]
        public void TestSymbolMarkSet_IncorrectValue()
        {
            var incorrectArray = new char[] { 'a', 'b', 'c', 'd' };
            var text = new Text();

            Assert.Throws<ArgumentException>(() => { text.SymbolMark = incorrectArray; }, "Должно возникать исключение");
        }

        [Test(Description = "Позитивный тест геттера MinWordLength")]
        public void TestMinWordLengthkGet_CorrectValue()
        {
            var expected = 3;
            var text = new Text();
            text.MinWordLength = expected;
            var actual = text.MinWordLength;

            Assert.AreEqual(expected, actual, "Геттер MinWordLength возвращает неверное значение.");
        }
    }
}
