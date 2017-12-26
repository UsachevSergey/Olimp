using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class DistanceHaming
    {
        public static void X()
        {
            string Main = Console.ReadLine();
            int MinDistance = Main.Length;
            int LenghtMainString = Main.Length;
            List<int> IndexMinDistance = new List<int>();

            int CountString = int.Parse(Console.ReadLine());

            for (int i = 0; i < CountString; i++)
            {
                string CurrentString = Console.ReadLine();
                int currentmin = 0;

                for (int k = 0; k < LenghtMainString; k++)
                {
                    //если символы одинаковы
                    if (CurrentString[k]!=Main[k])
                    {
                        currentmin++;
                    }
                    //если в текущей строке больше несоответствий чем допустимо то прервать
                    if (currentmin>MinDistance)
                    {
                        break;
                    }
                }
                //если столькоже сколько в наименьшей дистанции то добавляем индекс
                if (currentmin==MinDistance)
                {
                    IndexMinDistance.Add(i);
                }else if (currentmin < MinDistance) {
                    MinDistance = currentmin;
                    IndexMinDistance = new List<int>();
                    IndexMinDistance.Add(i);
                } 
            } 
            Console.WriteLine(IndexMinDistance.Count());
            for (int i = 0; i < IndexMinDistance.Count; i++)
            {
                Console.Write(IndexMinDistance[i]+1 + " ");
            }
            Console.WriteLine(); 
        }
    }
}
