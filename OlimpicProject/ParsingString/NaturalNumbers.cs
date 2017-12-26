using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class NaturalNumbers
    {
        public static void X()
        {
            string Main = "";
            for (int i = 1; i < 10001; i++)
            {
                Main += i.ToString();
            }
            string input = Console.ReadLine();
            Console.WriteLine(Main.IndexOf(input)+1);
        }
    }
}
