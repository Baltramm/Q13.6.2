using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Linq;

namespace Q13._6._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C://Users/Администратор/Downloads/Text1 (1).txt";
            string text = File.ReadAllText(path);

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] delim = new char[] { ' ' };
            var allWords = noPunctuationText.Split(delim, StringSplitOptions.RemoveEmptyEntries);

            var topWords = new Dictionary<string, long>();

            foreach (var word in allWords)
            {
                if (topWords.ContainsKey(word))
                {
                    topWords[word]++;
                }
                else
                {
                    topWords.Add(word, 1);
                }
            }
            var sortedTop = topWords.OrderByDescending(o => o.Value);
            Console.WriteLine("Какие 10 слов чаще всего встречаются в тексте:\n");

            var i = 0;
            foreach (var key in sortedTop)
            {
                i++;
                Console.WriteLine($"Слово '{key.Key}'  встречается {key.Value} раз\n");
                if (i == 10) break;
            }
            Console.ReadLine();
        } 

        
    }
}
