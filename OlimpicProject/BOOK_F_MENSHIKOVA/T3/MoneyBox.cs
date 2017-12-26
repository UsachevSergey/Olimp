using System;
using System.Collections.Generic;
using System.Linq;

namespace OlimpicProject.BOOK_F_MENSHIKOVA.T3
{
    class MoneyBox
    {
        public static void X()
        {

            string[] s = Console.ReadLine().Split();
            int CapacityWeightMoneyBox = int.Parse(s[1]) - int.Parse(s[0]);
            int CountTypeMoney = int.Parse(Console.ReadLine());
            List<money> ListMoney = new List<money>();

            //минимальная и максимальная стоимостькопилки на каждом шаге
            int[] Min = new int[CapacityWeightMoneyBox];
            int[] Max = new int[CapacityWeightMoneyBox];

            for (int i = 0; i < CountTypeMoney; i++)
            {
                string[] currents = Console.ReadLine().Split();
                ListMoney.Add(new money() { value = int.Parse(currents[0]), weight = int.Parse(currents[1]) });
            }
            //данные внесены

            //проходим по всем весам которые могут поместится в копилку
            for (int i = 1; i < CapacityWeightMoneyBox; i++)
            {
                //изначальные минимальные значения суммы денег в копилке
                int CurrentMin = 0;
                int CurrentMax = 0;

                //идем по всем типам монет
                for (int j = 0; j < CountTypeMoney; j++)
                {
                    //текущие значения монеты
                    int currentValue = ListMoney[j].value;
                    int currentWeight = ListMoney[j].weight;

                    //если вес монеты совпдает с тем что можно положить в копилку
                    if (i == currentWeight)
                    {
                        //если первое найденое решение или его стоимость меньше
                        if (CurrentMin == 0 || currentValue < CurrentMin)
                        {
                            CurrentMin = currentValue;
                        }
                        if (CurrentMax < currentValue)
                        {
                            CurrentMax = currentValue;
                        }
                    }
                    //если текущий вес копилки больше текущего веса монеты
                    else if (i > currentWeight)
                    {
                        //вычисляем какая станет максимальная 
                        //и минимальная стоимость копилки при добавление этой монеты
                        int maxmoneybox = Max[i - currentWeight] + currentValue;
                        int minmoneybox = Min[i - currentWeight] + currentValue;

                        //если сумма текущего веса и текущей монеты не равна стоимости монеты
                        //
                        if (minmoneybox != currentValue && CurrentMin == 0 || CurrentMin > minmoneybox)
                        {
                            CurrentMin = minmoneybox;
                        }
                        if (maxmoneybox != currentValue && CurrentMax < maxmoneybox)
                        {
                            CurrentMax = maxmoneybox;
                        }
                    } 
                }//конец прохода по типам
                Max[i] = CurrentMax;
                Min[i] = CurrentMin; 
            }
            //если максимальное значение в копилке есть и минимальное есть то 
            //вывести этот минимум и максимум
            if (Max[CapacityWeightMoneyBox]>0 && Min[CapacityWeightMoneyBox]>0)
            {
                Console.WriteLine(Min[CapacityWeightMoneyBox]+" "+ Max[CapacityWeightMoneyBox]);
            }
            else
            {
                Console.WriteLine("This is impossible");
            }


        }
    }
}
struct money
{
    public int weight, value;
}