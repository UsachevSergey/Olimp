using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Farmer
    {
        public static void X()
        {
            int P = int.Parse(Console.ReadLine());
            string[] Input = new string[P];
            int[,] leftDownQuard = new int[P, P];
            int max = 0;
            for (int i = 0; i < P; i++)
            {
                Input[i] = Console.ReadLine();
                for (int j = 0; j < Input[i].Length; j++)
                {
                    if (Input[i][j].ToString() == "1")
                    {
                        //точно квадрат 1x1
                        leftDownQuard[i, j] = 1;
                        try//исключаем обращение к -1
                        {
                            //если вышеслева больше нуля то проверять является ли квадратом
                            int dateLU = leftDownQuard[i - 1, j - 1];

                            if (dateLU > 0)
                            {
                                for (int k = 1; k < dateLU + 1; k++)
                                {
                                    if (leftDownQuard[i - k, j] > 0 && leftDownQuard[i, j - k] > 0)
                                    {
                                        leftDownQuard[i, j] += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        catch { }
                        if (max < leftDownQuard[i, j])
                        {
                            max = leftDownQuard[i, j];
                        }
                    }
                }
            }
            Console.WriteLine(max * max);



        }
    }
}
