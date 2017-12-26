using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class JustRightOrDown
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int CountStr = Convert.ToInt32(s[0]);
            int CountColunm = Convert.ToInt32(s[1]);
            int[,] Matrix = new int[CountStr, CountColunm];
            for (int i = 0; i < CountStr; i++)
            {
                List<int> CurrentSTR = Console.ReadLine().Split(' ').ToList().ConvertAll(aaaa => int.Parse(aaaa));
                for (int j = 0; j < CurrentSTR.Count; j++)
                {
                    Matrix[i, j] = CurrentSTR[j];
                }
            }//данные введены
            int[,] MatrixStep = new int[CountStr, CountColunm];
            MatrixStep[0, 0] = 1;//возможен 1 шаг в этом положение
            bool ewe = true;//пока есть куда идти
            int resultStep = 0;
            while (ewe)
            {
                ewe = false;
                int[,] CurentMatrixStep = new int[CountStr, CountColunm];

                for (int i = 0; i < CountStr; i++)
                {
                    for (int j = 0; j < CountColunm; j++)
                    {

                        if (MatrixStep[i,j]>0)
                        {
                            try // пробуем 
                            {
                                CurentMatrixStep[i + Matrix[i, j], j] += MatrixStep[i, j];
                                ewe = true;
                            }
                            catch { }
                            try // пробуем
                            {
                                CurentMatrixStep[i, j + Matrix[i, j]] += MatrixStep[i, j];
                                ewe = true;
                            }
                            catch { }  
                        } 
                    } 
                } 
                MatrixStep = CurentMatrixStep;
                resultStep += MatrixStep[CountStr-1, CountColunm-1];
                MatrixStep[CountStr - 1, CountColunm - 1] = 0;
            }

            Console.WriteLine(resultStep);
            
        }
    }
}
