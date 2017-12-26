using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.ParsingString
{
    class Encryption
    {
        public static void X()
        {
            string A = Console.ReadLine().Trim(); 
            string B = Console.ReadLine().Trim();   
                bool yes = true; 
                for (int i = 0; i < 27; i++)
                {
                    //тут делаем смещение на 
                    A = encod(A);

                    if (A.Contains(B))
                    {
                        Console.WriteLine(A);
                        yes = false;
                        break;
                    }
                   
                }
                if (yes)
                {
                    Console.WriteLine("IMPOSSIBLE");
                } 
        }

        static string encod(string A)
        {
            List<char> arraychar = A.ToCharArray().ToList();
            string result = "";
            for (int i = 0; i < arraychar.Count; i++)
            {
                result += (arraychar[i] - 1) < 65 ? (char)(arraychar[i] - 1 + 26) : (char)(arraychar[i] - 1);
            }
            return result;
        }
        

    }
}
