using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var reference = new Reference("John", 3, 16);
            var text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
            var scripture = new Scripture(reference, text);

            
            var words = text.Split(' ');

            
            var wordList = new List<Word>();
            foreach (var word in words)
            {
                wordList.Add(new Word(word));
            }

            
            Console.Clear();
            Console.WriteLine(scripture.GetReference().GetBook() + " " + scripture.GetReference().GetChapter() + ":" + scripture.GetReference().GetVerse());
            Console.WriteLine(string.Join(" ", wordList.Select(w => w.GetText())));

           
            while (wordList.Any(w => !w.GetIsHidden()))
            {
                
                Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
                var input = Console.ReadLine();

               
                if (input.ToLower() == "quit")
                {
                    break;
                }

                
                var random = new Random();
                var wordToHide = wordList[random.Next(wordList.Count)];
                wordToHide.SetIsHidden(true);

                
                Console.Clear();
                Console.WriteLine(scripture.GetReference().GetBook() + " " + scripture.GetReference().GetChapter() + ":" + scripture.GetReference().GetVerse());
                Console.WriteLine(string.Join(" ", wordList.Select(w => w.GetIsHidden() ? new string('_', w.GetText().Length) : w.GetText())));
            }

            
            Console.Clear();
            Console.WriteLine(scripture.GetReference().GetBook() + " " + scripture.GetReference().GetChapter() + ":" + scripture.GetReference().GetVerse());
            Console.WriteLine(string.Join(" ", wordList.Select(w => new string('_', w.GetText().Length))));
        }
    }
}