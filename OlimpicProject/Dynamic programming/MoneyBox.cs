using System;
using System.Collections.Generic; 

namespace OlimpicProject.Dynamic_programming
{
    class MoneyBox
    {
        public static void X()
        {

            string[] s = Console.ReadLine().Split();
            long CapacityWeightMoneyBox = long.Parse(s[1]) - long.Parse(s[0]);
            long CountTypeMoney = long.Parse(Console.ReadLine());
            List<money> ListMoney = new List<money>(); 
            //минимальная и максимальная стоимостькопилки на каждом шаге
            long[] Min = new long[CapacityWeightMoneyBox+1];
            long[] Max = new long[CapacityWeightMoneyBox+1];

            //заполняем масив номиналами и весом монет
            for (long i = 0; i < CountTypeMoney; i++)
            {
                string[] currents = Console.ReadLine().Split();
                ListMoney.Add(new money() { value = long.Parse(currents[0]), weight = long.Parse(currents[1]) });
            }
            //данные внесены

            //проходим по всем весам которые могут поместится в копилку
            for (int i = 1; i < CapacityWeightMoneyBox+1; i++)
            {
                //изначальные минимальные значения суммы денег в копилке
                long CurrentMin =  9999999;
                long CurrentMax = -9999999;

                //идем по всем типам монет
                for (int j = 0; j < CountTypeMoney; j++)
                {
                    //текущие значение монет
                    long currentValue = ListMoney[j].value;
                    //текущее значение веса
                    long currentWeight = ListMoney[j].weight;

                    //если вес монеты совпдает с тем что можно положить в копилку
                    if (i == currentWeight)
                    {
                        //если первое найденое решение или его стоимость меньше
                        if (CurrentMin == 0 || currentValue < CurrentMin)
                        {
                            CurrentMin = currentValue;
                        }
                        //если текущее значение больше
                        if (currentValue>CurrentMax)
                        {
                            CurrentMax = currentValue;
                        }
                    }

                    //если текущий вес копилки больше текущего веса монеты 
                    //т.е. если можно добавить
                    else if (i > currentWeight)
                    {
                        //вычисляем какая станет максимальная 
                        //и минимальная стоимость копилки при добавление этой монеты
                        //складываем предыдущий максимум с текущим значением
                        long maxmoneybox = Max[i - currentWeight] + currentValue;
                        //складываем предыдущий максимум с текущим значением
                        long minmoneybox = Min[i - currentWeight] + currentValue;

                        //если сумма текущего веса и текущей монеты не равна стоимости монеты
                        //
                        if (CurrentMin > minmoneybox)
                        {
                            CurrentMin = minmoneybox;
                        }
                        if ( CurrentMax < maxmoneybox)
                        {
                            CurrentMax = maxmoneybox;
                        }
                    } 
                }//конец прохода по типам
                //добавляем в масив минимумов и максимумов значения текущих мин макс
                Max[i] = CurrentMax;
                Min[i] = CurrentMin; 
            }
            //если максимальное значение в копилке есть и минимальное есть то 
            //вывести этот минимум и максимум
            if (Max[CapacityWeightMoneyBox]>0 && Min[CapacityWeightMoneyBox]< 9999999)
            {
                Console.WriteLine(Min[CapacityWeightMoneyBox]+" "+ Max[CapacityWeightMoneyBox]);
            }
            else
            {
                Console.WriteLine("This is impossible.");
            }


        }
    }

struct money
{
    public long weight, value;
}

}
