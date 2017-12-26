using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GreedyAlgorithm
{
    class FloatingNumber
    {
        public static void X()
        {

            //можно объединять в группы если число входим в диапазон начиная с первой группы
            //как только число перестаёт входить в диапазон то расширяем диапазон
      

            string[] s = Console.ReadLine().Split();
            int MaxStep = int.Parse(s[0]);
            int CountNumbers = int.Parse(s[1]); 
            List<int> ArrayNumber = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            ArrayNumber.Sort();
            int result = 1;
            int CurrentMaxNumber = ArrayNumber[0]+MaxStep*2; 
            for (int i = 0; i < CountNumbers; i++)
            {
                if (ArrayNumber[i]>CurrentMaxNumber)
                {
                    CurrentMaxNumber = ArrayNumber[i] + MaxStep * 2;
                    result++;
                }
            }
            Console.WriteLine(result);

        }
    }
}
