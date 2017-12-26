using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Units
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            int units = 0;
            while (N>1)
            {
                if (N%2==1)
                {
                    units++;
                }
                N/= 2;  
            }
            if (N==1)
            {
                units++;
            }
            Console.WriteLine(units);
        }
    }
}
