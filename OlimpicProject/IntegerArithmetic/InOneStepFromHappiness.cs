using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class InOneStepFromHappiness
    {
        public static void X()
        {
            int CountTicket = int.Parse(Console.ReadLine());
            for (int i = 0; i < CountTicket; i++)
            {
                string s = Console.ReadLine();
                int curentint = int.Parse(s);
                curentint++;
                s = curentint.ToString();
                while (s.Length<6)
                {
                    s = "0" + s;
                }
                curentint -= 2;
                string s2 = curentint.ToString();
                while (s2.Length < 6)
                {
                    s2 = "0" + s;
                }


                if (
                    int.Parse(s[0].ToString())+ int.Parse(s[1].ToString()) + int.Parse(s[2].ToString()) == int.Parse(s[3].ToString()) + int.Parse(s[4].ToString()) + int.Parse(s[5].ToString())
                    ||
                    int.Parse(s2[0].ToString()) + int.Parse(s2[1].ToString()) + int.Parse(s2[2].ToString()) == int.Parse(s2[3].ToString()) + int.Parse(s2[4].ToString()) + int.Parse(s2[5].ToString())
                    )
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                } 
            }
        }
    }
}
