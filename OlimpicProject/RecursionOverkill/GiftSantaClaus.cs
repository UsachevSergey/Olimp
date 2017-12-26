using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.RecursionOverkill
{
    class GiftSantaClaus
    {
        public static void X()
        { 
            string[] s = Console.ReadLine().Split(' ');
            int X = int.Parse(s[0]);
            int Y = int.Parse(s[1]);
            int Z = int.Parse(s[2]);
            int Max = int.Parse(s[3]);

            int maxX = Max / X;
            int maxY = Max / Y;
            int maxZ = Max / Z;
            int result = 0;
            for (int i = 0; i < maxX+1; i++)
            {
                for (int j = 0; j < maxY+1; j++)
                {
                    int summaXY = (i * X) + (j * Y);
                    if (summaXY>Max)
                    {
                        break;
                    }

                    if ((Max-summaXY) % Z==0)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
