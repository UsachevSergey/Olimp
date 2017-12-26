using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class ColoringMultiplicationTable
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            int countStr = int.Parse(s[0]);
            int countColumn = int.Parse(s[1]);
            int RED=0, GREEN=0, BLUE=0, BLACK = 0;
            for (int i = 1; i < countStr+1; i++)
            {
                for (int j = 1;j < countColumn+1;j++)
                {
                    int currres = i * j;
                    if (currres%5==0)
                    {
                        BLUE++;
                    }
                    else if (currres % 3 == 0)
                    {
                        GREEN++;
                    }
                    else if (currres % 2 == 0)
                    {
                        RED++;
                    }
                    else
                    {
                        BLACK++;
                    }
                }
            } 
            Console.WriteLine("RED : " + RED);

            Console.WriteLine("GREEN : " + GREEN);

            Console.WriteLine("BLUE : " + BLUE);

            Console.WriteLine("BLACK : " + BLACK);

        }
    }
}
