using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GraphTheory
{
    class ColorsRain
    {
        public static void X()
        {

            int CountHill = int.Parse(Console.ReadLine());
            List<List<int>> Hill = new List<List<int>>();
            for (int i = 0; i < CountHill; i++)
            {
                //string Currentstr = Console.ReadLine();
                List<int> CurrentHill = Console.ReadLine().Trim().Split().ToList().ConvertAll(a => int.Parse(a));
                Hill.Add(CurrentHill);
            }
            Console.ReadLine();
            List<int> ColorHill = Console.ReadLine().Trim().Split().ToList().ConvertAll(a => int.Parse(a));

            int result = 0;
            //проходим по всем ходмам и смотрим с каким цветом холма он соединен.
            //если цвета разные то добавлять плохой мост
            for (int i = 0; i < CountHill; i++)
            { 
                //проходим по всем с которыми соединен
                for (int l = 0; l < CountHill; l++)
                {
                    //если соединен смотрим цвета
                    if (Hill[i][l]==1)
                    {
                        if (ColorHill[i]!=ColorHill[l])
                        {
                            result++;
                        }
                    }
                } 
            }
            Console.WriteLine(result/2); 
        }
    }
}
