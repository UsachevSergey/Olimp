using System;
using System.Collections.Generic;
using System.Linq;

//Решено с помощью пояснения http://rain.ifmo.ru/cat/view.php/vis/combinations/permutations-2000


namespace OlimpicProject.Combinatorics
{
    class NextInvers
    {
        public static void X()
        { 
            int CountNumber = int.Parse(Console.ReadLine()); 
            List<int> ArrayNumber = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            List<int> result = new List<int>();
            result.Add(ArrayNumber[ArrayNumber.Count - 1]);
            ArrayNumber.RemoveAt(ArrayNumber.Count - 1);
            for (int i = CountNumber - 2; i >= 0; i--)
            {
                if (ArrayNumber[i]<result[result.Count()-1])
                {

                    int indexmin = 0;
                    for  (int q = 0; q < result.Count; q++)
                    {
                        //находим минимальный элемент в правой 
                        //части который больше того который смотрим справа
                        if (result[q] > ArrayNumber[i]) 
                        { 
                            indexmin = q;
                            break;
                        }
                    } 
                    ArrayNumber.Add(result[indexmin]); 
                    result[indexmin] = ArrayNumber[i];
                    result.Sort();
                    ArrayNumber.RemoveAt(i);
                    break;
                }
                else
                {
                    result.Add(ArrayNumber[i]); 
                    ArrayNumber.RemoveAt(i); 
                }
            }  



            ArrayNumber.AddRange(result);

            for (int i = 0; i < ArrayNumber.Count; i++)
            {
                Console.Write(ArrayNumber[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
