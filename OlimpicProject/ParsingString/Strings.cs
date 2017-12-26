using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class Strings
    {
        public static void X()
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            int result = 0;
            List<string> CollectString = new List<string>();
            for (int i = 0; i < B.Length; i++)
            {
                if (B.Length > 1)
                {
                    //тут на каждом цикле делаем сдвиг строки B и считаем количество вхождений в А 
                    B = B.Substring(1, B.Length - 1) + B[0].ToString();
                    CollectString.Add(B);
                }
            }
            CollectString = CollectString.Distinct().ToList();
            for (int i = 0; i < CollectString.Count; i++)
            {
                for (int r = 0; r < A.Length - B.Length + 1; r++)
                {
                    if (A.Substring(r, B.Length) == CollectString[i])
                    {
                        result++;
                    }
                }
            }  
            Console.WriteLine(result);
        }
    }
}
