using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class TransformationSequence2
    {

        public static void X()
        { 
            int CountNumber = int.Parse(Console.ReadLine()); 
            List<int> Numbers = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            Dictionary<int, int> DIC = new Dictionary<int, int>();

            for (int i = 0; i < CountNumber; i++)
            {
                int CurrentNumber = Numbers[i];
                //если уже занесен в библиотеку
                if (DIC.ContainsKey(CurrentNumber))
                {
                    //увеличиваем количество текущего элемента
                    DIC[CurrentNumber]++;
                }
                else
                {
                    DIC.Add(CurrentNumber, 1);
                }
            }

            int currentmax = -10212;
            int currentminnumber = 99999;
            foreach (var item in DIC)
            {
                //если встречается большее число раз 
                if (item.Value>currentmax)
                {
                    //сохраняем какое число встречалось больше всего раз
                    currentmax = item.Value;
                    currentminnumber = item.Key;
                }
                //если столькоже то сравниваем по номиналу числа
                else if (item.Value == currentmax && currentminnumber>item.Key)
                {
                    //меняем на число которое встречается столько же раз но меньше по номиналу
                    currentminnumber = item.Key;
                }
            }

            foreach (var item in Numbers)
            {
                //если число не то которое передвинуть в конец то  ператаем его
                if (item!=currentminnumber)
                {
                    Console.Write(item +" ");
                }
            }
            for (int i = 0; i < currentmax; i++)
            {
                Console.Write(currentminnumber + " ");
            }
            Console.WriteLine();


        }
    }
}
