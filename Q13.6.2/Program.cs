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
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
                string[] wordsArray = noPunctuationText.Split(new char[] { ' ' });
                var topWords = new Dictionary<string, int>();
                foreach (string word in wordsArray)
                {
                    if (topWords.ContainsKey(word)) topWords[word]++;
                    else topWords.Add(word, 1);
                }

                foreach (var top in topWords)
                {
                    Console.Write(top.Key + ": ");
                    foreach (var city in Convert.ToString(top.Value))
                        Console.Write(city + " ");

                    Console.WriteLine();
                }

            }

        }
    }
}
