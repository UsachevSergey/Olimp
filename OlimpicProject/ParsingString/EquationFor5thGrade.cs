using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class EquationFor5thGrade
    {
        public static void X()
        {
            string s = Console.ReadLine();
            string mark = s[1].ToString();
            string s1 = s[0].ToString(); 
            string s2 = s[2].ToString(); 
            string s3 = s[4].ToString();
            if (s1 == "x")
            {
                if (mark == "+")
                {
                    Console.WriteLine(int.Parse(s3) - int.Parse(s2));
                }
                else
                {
                    Console.WriteLine(int.Parse(s3) + int.Parse(s2));
                }
            }
          else  if (s2 == "x")
            {
                if (mark == "+")
                {
                    Console.WriteLine(int.Parse(s3) - int.Parse(s1));
                }
                else
                {
                    Console.WriteLine(int.Parse(s1) - int.Parse(s3));
                }
            }
           else
            {
                if (mark == "+")
                {
                    Console.WriteLine(int.Parse(s1) + int.Parse(s2));
                }
                else
                {
                    Console.WriteLine(int.Parse(s1) - int.Parse(s2));
                }
            }
        }

    }
}
