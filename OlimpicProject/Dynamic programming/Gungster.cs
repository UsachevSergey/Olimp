using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Gungster
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Replace("  ", " ").Trim().Split();
            int CountGungster = int.Parse(s[0]);
            int MaxTime = int.Parse(s[2]);
            int MaxOpenDoor = int.Parse(s[1]);
            List<G> ListGungser = new List<G>();
            string[] time = Console.ReadLine().Replace("  ", " ").Trim().Split();
            for (int i = 0; i < CountGungster; i++)
            {
                ListGungser.Add(new G() { Time = int.Parse(time[i]) });
            }
            string[] money = Console.ReadLine().Replace("  ", " ").Trim().Split();
            for (int i = 0; i < CountGungster; i++)
            {
                ListGungser[i].Money = int.Parse(money[i]);
            }
            string[] compet = Console.ReadLine().Replace("  ", " ").Trim().Split();
            for (int i = 0; i < CountGungster; i++)
            {
                ListGungser[i].Completenes = int.Parse(compet[i]);
            }

            //сортируем по времени прихода
            ListGungser = ListGungser.OrderBy(assa => assa.Time).ToList();
            //убираем всех кто не успеет войти из за полноты
            ListGungser.RemoveAll(asa => asa.Completenes > asa.Time);
            //пересчитываем сколько гангстеров 
            CountGungster = ListGungser.Count;

            int[] result = new int[CountGungster];
            //проходим по всем гангстерам и смотрим сколько 
            //будет максимальная выручка если он зайдет последним
            for (int i = 0; i < CountGungster; i++)
            {
                //изначально текущий максимум будет равен текущему состоянию гангстера
                int currentmaximum = ListGungser[i].Money;

                //проходим по предыдущим гангстерам и смотрим с какого момента можно былобы зайти и было ли это выгодно
                for (int prev = 0; prev < i; prev++)
                {
                    //если время между входом первого и входом последнего 
                    //достаточно чтобы избавится от разности в полноте
                    if (Math.Abs(ListGungser[prev].Time - ListGungser[i].Time) >= Math.Abs(ListGungser[prev].Completenes - ListGungser[i].Completenes))
                    {
                        //смотреть что больше предыдуший найденый максимум или результат входа предыдущего и текущее богатство
                        currentmaximum = Math.Max(currentmaximum, result[prev] + ListGungser[i].Money);
                    }
                }
                //вписываем в таблицу результатов
                result[i] = currentmaximum;
            }
            int max = 0;
            for (int i = 0; i < result.Count(); i++)
            {
                if (result[i] > max)
                {
                    max = result[i];
                }
            }
            Console.WriteLine(max);




        }

        class G
        {
            public int Completenes, Time, Money;
        }
    }
}
