using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.BOOK_F_MENSHIKOVA.T1
{
    class IncreasingSubSequence
    {
        public static void X()
        {
            int CountNumbers = int.Parse(Console.ReadLine());
 
            List<int> ListNumbers = Console.ReadLine().Split().ToList().ConvertAll(d => int.Parse(d));
            //масив для хранение результатов 
            int[] ArrayResults = new int[CountNumbers]; 
            //длина до 1 цифры = 1 
            ArrayResults[0] = 1; 
                for (int i = 0; i < CountNumbers; i++)
                {
                    int currentmax = 1;
                    //просматриваем последовательно объекты и смотрим наиболее выгодный вариант
                    for (int j = 0; j < i; j++)
                    {
                        //если число меньше предыдущих
                        if (
                            ListNumbers[j] < ListNumbers[i]
                            && currentmax <= ListNumbers[j]) {
                        currentmax = ArrayResults[j] + 1;
                    }
                    }
                    ArrayResults[i] = currentmax;
                }
                int result = 0;
                int indexnumber = 0;
                for (int i = 0; i < ArrayResults.Count(); i++)
                {
                    if (ArrayResults[i] > result)
                    {
                        result = ArrayResults[i];
                        indexnumber = i;
                    }
                }
                Console.WriteLine(result);

                string allnumbers = "";
                //добавляем 1  чтобы первый элемент учитывался 
                int maxelement = ListNumbers[indexnumber] + 1;
                for (int i = indexnumber; result > 0; i--)
                {
                    //если совпадают максимальные длинны
                    //и элемент меньше предыдущего
                    if (ArrayResults[i] == result
                        &&
                        ListNumbers[i] < maxelement
                        )
                    {
                        allnumbers = ListNumbers[i] + " " + allnumbers;
                        result--;
                        maxelement = ListNumbers[i];

                    }
                }
                Console.WriteLine(allnumbers);
            

        }
    }
}
