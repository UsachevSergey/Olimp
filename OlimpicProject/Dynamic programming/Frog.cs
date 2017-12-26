using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Frog
    {
        public static void X()
        {
            string[] S = Console.ReadLine().Split();
            int SIZE = int.Parse(S[0]);
            int[,] Matrix = new int[SIZE+1, SIZE+1];
            for (int str = 1; str < SIZE+1; str++)
            {
                S = Console.ReadLine().Split();
                for (int col = 0; col < SIZE; col++)
                {
                    Matrix[str , col+ 1] = int.Parse(S[col]);
                }
            }
            //данные получены



            int[,] Result = new int[SIZE+1,SIZE+1]; 
            //проходим по столбцам  
            for (int numbetcol = 1; numbetcol < SIZE+1; numbetcol++)
            {
                //хранение пром максимумов
                int[] currentcolumn = new int[SIZE + 1];

                //просматриваем строки и смотрим наиболее выгодный
                for (int numberstr = 1; numberstr < SIZE+1; numberstr++)
                { 
                     //от 0 колонки до проверяемой
                    for (int i = 1; i < numbetcol; i++)
                    { 
                        
                        //от 0 строки до строки размер поля - проверяемая
                        for (int j = 1;j<=SIZE-numberstr; j++)
                        {  
                                //если сумма даст больше чем то что находится в ячейке ниже
                                if (Matrix[numberstr, numbetcol] + Matrix[j, i] > Matrix[numberstr+j, numbetcol] )
                                { 
                                int cc = Matrix[j, i] + Matrix[numberstr, numbetcol];
                                if (cc> currentcolumn[numberstr + j])
                                {
                                    currentcolumn[numberstr + j] = cc;
                                } 
                                }  
                        }
                        
                    }
                     
                }
                //проходим и перезаписываем максимум после просмотра всей колоникм
                for (int ll = 1; ll < SIZE+1; ll++)
                {
                    if (currentcolumn[ll] > Matrix[ll, numbetcol])
                    {
                        Matrix[ll, numbetcol] = currentcolumn[ll];
                    }
                }
            }
            int result = 0; 
            for (int i = 1; i < SIZE+1; i++)
            {
                for (int j = 1; j < SIZE+1; j++)
                {
                    if (Matrix[i,j]>result)
                    {
                        result = Matrix[i, j];
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
