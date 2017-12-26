using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class Wagon
    {
        public static void X()
        {
            //количество вагонов
            int CountWagon = int.Parse(Console.ReadLine()); 
            //перечисление вагонов
            List<int> ArrayWagon = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));

            //текущий вагон
            int CurrentNumberWagon = ArrayWagon[0];
            int CountBreak=0;
            //идем по всем вагонам.
            for (int i = 1; i < CountWagon; i++)
            {
                //если текущий номер на 1 меньше следующего то разрывать не надо
                if (CurrentNumberWagon==ArrayWagon[i]-1)
                {  }  else {
                    //добавляем количество разрывов

                    CountBreak++;
                }
                CurrentNumberWagon = ArrayWagon[i];
            }

            Console.WriteLine(CountBreak);
        }
    }
}
