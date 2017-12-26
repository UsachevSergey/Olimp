using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Ents
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            int CountWord = int.Parse(s[0]);
            int modul = int.Parse(s[1]);
            int[] ArrayWord = new int[CountWord+1];
            ArrayWord[1] = 0;
            if (CountWord > 1)
            {
                ArrayWord[2] = 1%modul;
                for (int i = 3; i < CountWord + 1; i++)
                {
                    ArrayWord[i] = (ArrayWord[i - 1] + (i % 2 == 0 ? ArrayWord[i / 2] : 0)) % modul;
                }
            }
            Console.WriteLine(ArrayWord[CountWord]);



        }
    }
}
