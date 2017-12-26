using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class RuneWords
    {
        public static void X()
        {
            string STR = Console.ReadLine();
            char[] UpperLetter = new char[26];
            string ulstr = "QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 26; i++)
            {
                UpperLetter[i] = ulstr[i];
            }
            List<string> Rune = STR.Split(UpperLetter).ToList();
            string Result = "Yes";
            if (Rune[0]!="")
            {
                Result = "No";
            }
            for (int i = 1; i < Rune.Count; i++)
            {
                if (Rune[i].Count()>3 || Rune[i].Count()<1)
                {
                    Result = "No";
                    break;
                }
            }

            Console.WriteLine(Result);
        }
    }
}
