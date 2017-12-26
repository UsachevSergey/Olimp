using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class MyltiplicationGame
    {
        public static void X()
        {

            long Number = long.Parse(Console.ReadLine());

             
            if (Number<10)
            {
                //выиграет первым же ходом
                Console.WriteLine("Stan wins.");
            }
            else
            {
                while (Number>9)
                {
                    long a = Number;
                    Number = (a / 9) + (a % 9) - 1;
                }



            }

        }
    }
}
