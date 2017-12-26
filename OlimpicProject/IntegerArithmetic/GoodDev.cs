using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class GoodDev
    {
        public static void X()
        {
            //вводимое число
            int N = int.Parse(Console.ReadLine());
            //максимальный делитель снаячала само число
            int Max_del = N;
            //минимальная сумма делителя 
            int Max_sum = 0;
            //проходим по цифрам от 1 до N
            for (int i = 1; i < N + 1; i++)
            {
                //если N делится на текущую цифру
                if (N % i == 0)
                {
                    //считываем в строку теку
                    string current_c = i.ToString();
                    //сумма при текущем деление
                    int current_sum = 0;
                    //проходим по всем цифрам делителя и смотрим на полученную сумму
                    for (int j = 0; j < current_c.Count(); j++)
                    {
                        current_sum += int.Parse(current_c[j].ToString());
                    }
                    //если сумма цифр больше максимального то ставим максимальную сумму 
                    if (current_sum > Max_sum)
                    {
                        Max_sum = current_sum;
                        Max_del = i;
                    }
                }
            }
            Console.WriteLine(Max_del);
        }
    }
}
