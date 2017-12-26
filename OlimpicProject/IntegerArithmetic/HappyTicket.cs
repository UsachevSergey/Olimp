using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class HappyTicket
    {
        public static void X()
        {
            string S = Console.ReadLine();
            if (int.Parse(S[0].ToString())+ int.Parse(S[1].ToString())+ int.Parse(S[2].ToString())== int.Parse(S[3].ToString())+ int.Parse(S[4].ToString())+ int.Parse(S[5].ToString()))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
