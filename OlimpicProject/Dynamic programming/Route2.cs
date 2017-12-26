using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    //НЕ РЕШЕНО
    class Route2
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            int CountStrCol = int.Parse(s[0]);
            int CountStep = int.Parse(s[1]);
            //сторим матрицу для цифр
            int[,] MatrixNumber = new int[CountStrCol, CountStrCol];
            
            //заполняем 
            for (int i = 0; i < CountStrCol; i++)
            {
                string[] currentinput = Console.ReadLine().Split();

                for (int jjj = 0; jjj < CountStrCol; jjj++)
                {
                    MatrixNumber[i, jjj] = int.Parse(currentinput[jjj]);
                } 
            }

            //сторим матрицу для результатов 
            int[,] MatrixResult = new int[CountStrCol, CountStrCol];
            MatrixResult[0, 0] = MatrixNumber[0, 0];
            bool CurrentParity = false;
            int currentcarry = 0;
            //проходим по всем шагам и проставляем 
            for (int step = 1; step < CountStep; step++)
            {
                 
                //идем по строкам
                for (int i = 0; i < CountStrCol; i++)
                { 
                    //выставляем четное нечетное 
                    if (CountStrCol % 2 == 1 &&CurrentParity )
                    {
                        currentcarry = 0;
                    }
                    else
                    {
                        currentcarry = 1;
                    }
                    //идем по столбцам
                    for (int j = currentcarry; j < CountStrCol; j+=2)
                    {
                        //если клетка белая/черная (подходит) то дальше смотрим дошла ли волна 
                         
                            if ( i + j < step)
                            {//если уже был во всех сторонах
                                int left = 0;
                                int right = 0;
                                int up = 0;
                                int down = 0;
                                try { left = MatrixNumber[i, j ] + MatrixResult[i, j - 1]; } catch { }
                                try { right = MatrixNumber[i, j ] + MatrixResult[i, j + 1]; } catch { }
                                try { up = MatrixNumber[i , j] + MatrixResult[i - 1, j]; } catch { }
                                try { down = MatrixNumber[i, j] + MatrixResult[i + 1, j]; } catch { }
                                MatrixResult[i, j] = Math.Max(Math.Max(Math.Max(up, down), left), right);
                            }
                            else if(i + j == step)
                            {//если только пришел в эту клетку то можно смотреть только на лево и вверх
                                int left = 0; 
                                int up = 0; 
                                try { left = MatrixNumber[i, j ] + MatrixResult[i, j - 1]; } catch { } 
                                try { up = MatrixNumber[i, j] + MatrixResult[i - 1, j]; } catch { }
                                MatrixResult[i, j] = Math.Max(up, left);
                            } 
                    }
                    //меняем четность 
                    CurrentParity = !CurrentParity;
                } 
            }


            int maxResult = 0;
            for (int i = 0; i < CountStrCol; i++)
            {
                for (int j = 0; j < CountStrCol; j++)
                {
                    if (MatrixResult[i,j]>maxResult)
                    {
                        maxResult = MatrixResult[i, j];
                    }
                } 
            }
            Console.WriteLine(maxResult);



        }

    }
}
