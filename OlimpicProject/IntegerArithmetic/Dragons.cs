using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Dragons
{
    public static void X()
    {
        int CountHead = int.Parse(Console.ReadLine());
        //делить логичнее всего или на 2 или на 3..так как те числа что больше дают меньший результат

        //получаем сколько раз можно умножить на 2
        int CountMultiplicationTwo = CountHead % 3;
        //получаем сколько раз можно умножить на 3
        int CountMultiplicationThree = CountHead / 3; 
     
        //если  остаток от деления на 3 = 1 то выгодней будет представить 
        //последнюю тройку и единицу в виде произведений 2*2 чем в виде 3*1

        if (CountMultiplicationTwo == 1)
        { 
            CountMultiplicationThree--;
            CountMultiplicationTwo = 2;
        }
        //если остаток от деления на 3 =2 . нужно будет умножить на 3 только 1 раз
        else if (CountMultiplicationTwo == 2)
        {
            CountMultiplicationTwo = 1;
        }
        //если голов меньше 4 то делить нечего
        if (CountHead<4)
        {
            Console.WriteLine(CountHead);
        }
        else
        {
            //умножаем нужное количество раз на 2
            long result = 1;
            for (int i = 0; i < CountMultiplicationTwo; i++)
            {
                result *= 2;
            }
            //умножаем нужное количество раз на 3
            for (int i = 0; i < CountMultiplicationThree; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
        }



    }
}
  