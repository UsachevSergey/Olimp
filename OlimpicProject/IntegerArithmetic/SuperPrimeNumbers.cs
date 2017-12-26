using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class SuperPrimeNumbers
    {
        public static void X()
        {
            int Number = int.Parse(Console.ReadLine());
            List<int> ListFirst = new List<int>();

            List<int> ListSecond = new List<int>();
            //для 500 сватит
            //заполняем масив цифрами
            for (int i = 2; i < 33500; i++)
            {
                ListFirst.Add(i);
            }
            for (int i = 2; i < 33500; i++)
            {
                //если числа нету в списке результата то добавить его туда 
                //и убрать из первого списка все которые делятся на текущее число
                if (ListFirst.Contains(i))
                {
                    ListSecond.Add(i);

                    ListFirst.RemoveAll(ss => ss % i == 0);
                }
            }//вывести число из списка результата которое простое и засположено под номером введеным
            Console.WriteLine(ListSecond[ListSecond[Number-1]-1]);

        }
    }
}
