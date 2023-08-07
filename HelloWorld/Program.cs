using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args)
        {
            var sentence = "This is a very very long sentence. It can be longer than this but I think this is enough";
            var maxLength = 20;

            if (sentence.Length <maxLength)
            {
                Console.WriteLine(sentence);
                Console.ReadLine();
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacterCount = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacterCount += word.Length + 1;
                    if (totalCharacterCount > maxLength)
                        break;
                }

                var summary = String.Join(" ",summaryWords) + "...";
                Console.WriteLine(summary);
                Console.ReadLine();
            }
        }
    }
}
