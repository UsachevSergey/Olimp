using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class BaseTerror
    {
        public static void X()
        {
            string coordpattern = Console.ReadLine();
            int IcoordPattern = int.Parse(coordpattern.Split()[0]);
            int JcoordPattern = int.Parse(coordpattern.Split()[1]);
            char[,] MatrixPattern = new char[IcoordPattern, JcoordPattern];
            for (int i = 0; i < IcoordPattern; i++)
            {
                string pat = Console.ReadLine();
                for (int j = 0; j < JcoordPattern; j++)
                {
                    MatrixPattern[i, j] = pat[j];
                }
            }
            string coordDesert = Console.ReadLine();
            int IcoordDesert = int.Parse(coordDesert.Split()[0]);
            int JcoordDesert = int.Parse(coordDesert.Split()[1]);
            char[,] MatrixDesert = new char[IcoordDesert, JcoordDesert];
            for (int i = 0; i < IcoordDesert; i++)
            {
                string Desert = Console.ReadLine();
                for (int j = 0; j < JcoordDesert; j++)
                {
                    MatrixDesert[i, j] = Desert[j];
                }
            }
            int countStructure = 0;
            //данные внесены
            //идем по данным и сравниваем с паттерном
            for (int i = 0; i < IcoordDesert; i++)
            { 
                for (int j = 0; j < JcoordDesert; j++)
                {
                    
                    //если длина и ширина оставшегося поля больше или равно длине шаблона
                    
                    if (JcoordDesert-j>=JcoordPattern && IcoordDesert - i >= IcoordPattern)
                    {
                        bool yes = true; ;
                        for (int ii = 0; ii < IcoordPattern; ii++)
                        {
                            if (yes)
                            {
                                for (int jj = 0; jj < JcoordPattern; jj++)
                                {
                                    if (MatrixPattern[ii, jj] == '#' && MatrixDesert[i + ii, j + jj] != '#')
                                    {
                                        yes = false;
                                        break;
                                    }
                                }
                            }
                        }

                        if (yes)
                        {
                            countStructure++;
                        } 
                    }
                }
            }
            Console.WriteLine(countStructure);



        }
    }
}
