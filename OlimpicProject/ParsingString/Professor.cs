using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class Professor
    {
        public static void X()
        {
            string[] input = Console.ReadLine().Split();
            int CountLetterinWord = int.Parse(input[1]);
            int CountLetter = int.Parse(input[0]);
            List<string> words = new List<string>();
            string input2 = Console.ReadLine();
            for (int i = 0; i < CountLetter- CountLetterinWord+1; i++)
            {
                words.Add(input2.Substring(i, CountLetterinWord));
            }
            words = words.Distinct().ToList();
            Console.WriteLine(words.Count);

        }
    }
}
