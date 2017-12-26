using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class MissionJosephusFlavius
    {
        public static void X()
        {
            string s = Console.ReadLine();
            int CountHuman = int.Parse(s.Split(' ')[0]);
            int EveryDead =  int.Parse(s.Split(' ')[1]);
            int[] humans = new int[CountHuman];
            for (int i = 0; i < humans.Count(); i++)
            {
                humans[i] = 1;
            }
            int lastdead = 0;
            //пока есть люди
            while (CountHuman>1)
            {
                int curentdead = 0;
                //если последний убитый был последним в списке то переводим курсор но первого 
                if (lastdead==humans.Count())
                {
                    lastdead = 0;
                }
                for (int i = lastdead; i < humans.Count(); i++)
                {

                    //если текущий жив то добавить в счетчик единицу
                    if (humans[i]==1)
                    {
                        curentdead++;  
                    } 
                    //если счетчик равен нужному числу убиваем текущего человека
                    if (curentdead == EveryDead)
                    {
                        humans[i] = 0;
                        lastdead = i;
                        CountHuman--;
                        i = 999999;
                         
                    }
                    else
                    {//если счетчик не достиг то проверить не замкнулся ли круг
                        //если стоит на последнем то перевести счетчик в состояние -1
                        if (i== humans.Count()-1)
                        {
                            i = -1;
                        }
                    }
                }
            }
            //ищем выжевшего
            for (int i = 0; i < humans.Count(); i++)
            {
                if (humans[i]==1)
                {
                    Console.WriteLine(i+1);
                    break;
                }
            }


        }
    }
}
