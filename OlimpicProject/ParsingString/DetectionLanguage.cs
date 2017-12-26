using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class DetectionLanguage
    {
        public static void X()
        {
            int Counttes =int.Parse( Console.ReadLine());
            for (int i = 0; i < Counttes; i++)
            {
                string currentstring = Console.ReadLine();
                if (currentstring.Count(a => a == '0') == currentstring.Count(a => a == '1') &&
                    currentstring.Count(a => a == '0') == currentstring.Count(a => a == '2') &&
                    currentstring.LastIndexOf('0') < currentstring.IndexOf('1') &&
                    currentstring.LastIndexOf('1') < currentstring.IndexOf('2') 
                    )
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
}
