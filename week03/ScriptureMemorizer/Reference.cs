using System;

namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public Reference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
        }

        public string GetBook()
        {
            return _book;
        }

        public int GetChapter()
        {
            return _chapter;
        }

        public int GetVerse()
        {
            return _verse;
        }

        public int GetEndVerse()
        {
            return _endVerse;
        }
    }
}