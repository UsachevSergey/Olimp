using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GreedyAlgorithm
{
    class Summa2
    {
        public static void X()
        {
            int inputnumber = int.Parse(Console.ReadLine());
            int result = 0;
            //запускаем цикл для каждой цифры
            for (int n1 = 1; n1 < inputnumber; n1++)
            {
                if (n1*4>inputnumber)
                {
                    break;
                }
                //вторая цифра может начинатся не меньше чем с первой
                for (int n2 = n1; n2 < inputnumber; n2++)
                {
                    if (n2*3>inputnumber)
                    {
                        break;
                    }
                    //третья цифра может начинатся не меньше чем со второй
                    for (int n3 = n2; n3 < inputnumber; n3++)
                    {
                        int n123 = n1 + n2 + n3; 
                            //если сумма цифр равна вводимой цифр
                            if (n123+n3<=inputnumber)
                            {
                                result++;
                            }
                            else if (n123>inputnumber)
                            {
                                break;
                            }
                         
                    }
                }
            }
            Console.WriteLine(  result);


        }
    }
}
