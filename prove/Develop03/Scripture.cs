using System;

    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);
            _words = new List<Word>();

            string[] splitText = text.Split(' ');
            foreach (string word in splitText)
            {
                _words.Add(new Word(word));
            }
        }

        public bool HideRandomWord()
        {
            List<Word> visibleWords = IsCompletelyHidden();
            if (visibleWords.Count < 1)
                return false;

            Random random = new Random();
            int randomIndex1 = random.Next(visibleWords.Count);
            int randomIndex2 = random.Next(visibleWords.Count);
            int randomIndex3 = random.Next(visibleWords.Count);
            visibleWords[randomIndex1].Hide();
            visibleWords[randomIndex2].Hide();
            visibleWords[randomIndex3].Hide();
            return true;
        }
        public void GetDisplayText()
        {
            Console.WriteLine($"{_reference}:");
            foreach (Word word in _words)
            {
                if (word.IsHidden())
                {
                    Console.Write(new string('_', word.Show().Length) + " ");
                }
                else
                {
                    Console.Write(word.Show() + " ");
                }
            }
        }
        private List<Word> IsCompletelyHidden()
        {
            List<Word> hiddenWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                    hiddenWords.Add(word);
            }
            return hiddenWords;
        }
    }
