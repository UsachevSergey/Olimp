using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class ChessBoard
    {
        public static void X()
        {
            int CountBakedCage = int.Parse(Console.ReadLine());
            bool[,] Board = new bool[10, 10];
            for (int i = 0; i < CountBakedCage; i++)
            {
                string[] currents = Console.ReadLine().Split(' ');
                Board[int.Parse(currents[0]), int.Parse(currents[1])] = true;
            }
            int P = 0;
            //тут есть фигура
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    //если выпелена 
                    if (Board[i,j])
                    {
                        if (!Board[i + 1, j])
                        {
                            P++;
                        }
                        if (!Board[i - 1, j])
                        {
                            P++;
                        }
                        if (!Board[i, j+1])
                        {
                            P++;
                        }
                        if (!Board[i, j-1])
                        {
                            P++;
                        }
                    }
                }
            }
            Console.WriteLine(P);


        }
    }
}
