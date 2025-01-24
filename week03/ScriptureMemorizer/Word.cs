using System;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public string GetText()
        {
            return _text;
        }

        public bool GetIsHidden()
        {
            return _isHidden;
        }

        public void SetIsHidden(bool isHidden)
        {
            _isHidden = isHidden;
        }
    }
}