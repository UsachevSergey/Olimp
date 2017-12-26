using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class LayingTiles
    {
        public static void X()
        {
            string[] StrCol = Console.ReadLine().Split();
            int str = int.Parse(StrCol[0]);
            int col = int.Parse(StrCol[1]);
            int CountCommand = int.Parse(Console.ReadLine());
            bool[,] Matrix = new bool[str+1, col+1];
            for (int i = 0; i < str; i++)
            {
                Matrix[i, col] = true;
            }
            for (int i = 0; i < col; i++)
            {
                Matrix[str,i] = true;
            }
            int result = 0;
            for (int i = 0; i < CountCommand; i++)
            {
                string[] CoordinateAndType = Console.ReadLine().Replace("  "," ").Trim().Split(' ');
                int x = int.Parse(CoordinateAndType[1])-1;
                int y = int.Parse(CoordinateAndType[2])-1;
                int type = int.Parse(CoordinateAndType[0]);
                try
                {
                    switch (type)
                    {
                        case 1:
                            if (!Matrix[x,y+1]&& !Matrix[x+1, y + 1] &&!Matrix[x+1, y])
                            {
                                Matrix[x, y + 1] = true;
                                Matrix[x + 1, y + 1] = true;
                                Matrix[x + 1, y] = true;
                                result += 3;
                            }
                            break;
                        case 2:
                            if (!Matrix[x, y] && !Matrix[x + 1, y + 1] && !Matrix[x + 1, y])
                            {
                                Matrix[x, y] = true;
                                Matrix[x + 1, y + 1] = true;
                                Matrix[x + 1, y] = true;
                                result += 3;
                            }
                            break;
                        case 3:
                            if (!Matrix[x, y] && !Matrix[x + 1, y + 1] && !Matrix[x, y+1])
                            {
                                Matrix[x, y] = true;
                                Matrix[x + 1, y + 1] = true;
                                Matrix[x, y+1] = true;
                                result += 3;
                            }
                            break;
                        case 4:
                            if (!Matrix[x, y] && !Matrix[x, y + 1] && !Matrix[x + 1, y])
                            {
                                Matrix[x, y] = true;
                                Matrix[x, y + 1] = true;
                                Matrix[x + 1, y] = true;
                                result += 3;
                            }
                            break;
                        default:  break;
                    } 
                }
                catch { }
            }

            Console.WriteLine(result);

        }
    }
}
