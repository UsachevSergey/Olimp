using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class Numerologist
    {
        public static void X()
        {
            string S = Console.ReadLine();
            int CountTransfornation = 0;
            int CurrentNumbers = 999;
            if (S.Length > 1)
            {
                while (CurrentNumbers.ToString().Length > 1)
                {
                    CurrentNumbers = 0;
                    for (int i = 0; i < S.Length; i++)
                    {
                        CurrentNumbers += int.Parse(S[i].ToString());
                    }
                    S = CurrentNumbers.ToString();
                    CountTransfornation++;
                }
                Console.WriteLine(CurrentNumbers + " " + CountTransfornation);
            }
            else
            {
                Console.WriteLine(S + " " + 0);
            }
        }
    }
}