using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class UnpackingString
    {
        public static void X()
        {
            string S = Console.ReadLine();
            string result = "";
            int number = 1;
            bool LastNumber = false;
            for (int i = 0; i < S.Length; i++)
            {
                int currentnumber = 0;
                string currentchar = S[i].ToString();
                //если число
                if (int.TryParse(currentchar, out currentnumber))
                {
                    if (LastNumber)
                    {
                        number = number * 10 + currentnumber;
                    }
                    else
                    {
                        number = currentnumber;
                        LastNumber = true;
                    }
                }
                else
                {
                    //если это буква то смотрим было ли число
                    result = result.PadRight(result.Length + number, currentchar.ToCharArray()[0]);
                    number = 1;
                    LastNumber = false;
                }
            }

            for (int i = 0; i < result.Length; i += 40)
            {
                if (result.Length - i < 40)
                {
                    Console.WriteLine(result.Substring(i));
                }
                else
                {
                    Console.WriteLine(result.Substring(i, 40));
                }
            }
        }
    }
}
