using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class Words
    {
        public static void X()
        {
            string S = Console.ReadLine();
            string result = "";
            result += S[0].ToString();
            
            List<int> Fib = new List<int>() { 1, 1 };
            for (int i = 2; Fib.Last()<30000; i++)
            {
                Fib.Add(Fib[i - 1] + Fib[i - 2]);
            }
            try
            {
                for (int i = 2; i < S.Length+1; i++)
                {
                    result += S[Fib[i]-1].ToString();
                }
            }
            catch
            {

            }
            Console.WriteLine(result);


        }
    }
}
