using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class CommunityRobots
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int CountRob = int.Parse(s[0]);
            int CountYearLive = int.Parse(s[1]);
            community c = new community(CountRob);

            for (int i = 0; i < CountYearLive-1; i++)
            {
                c.LiveIsYear(); 
            } 
            Console.WriteLine(c.Totalrobots());


        }

        class community
        {
            long totalrobots;

            long dead3year;
            long groupof3;
            long groupof5;
            long dead2year;
            long dead1year;

            public long Totalrobots()
            {
                return totalrobots;
            }

            public community(long totalrobots)
            {
                this.totalrobots = totalrobots;
                dead1year = totalrobots;
            }
            
            /// <summary>
            /// разбиваем по кланам
            /// </summary>
            void NewYearAssociation()
            {
                //в зависимости от того сколько есть роботов разбиваем на наиболее выгодные группы
                if (totalrobots % 5 == 0)
                {
                    groupof5 = totalrobots / 5;
                    if (groupof5 < 0)
                    {
                        groupof5 = 0;
                    }
                    groupof3 = (totalrobots- groupof5 * 5) / 3;
                }
                else
                if (totalrobots % 5 ==1)
                {
                    groupof5 = (totalrobots / 5) - 1;
                    if (groupof5 < 0)
                    {
                        groupof5 = 0;
                    }
                    groupof3 = (totalrobots - groupof5 * 5) / 3;
                }
                else
                if (totalrobots % 5 == 2)
                {
                    groupof5 = totalrobots / 5 -2;
                    if (groupof5 < 0)
                    {
                        groupof5 = 0;
                    }
                    groupof3 = (totalrobots - groupof5 * 5) / 3;
                }
                else
                if (totalrobots % 5 == 3)
                {
                    groupof5 = totalrobots / 5;
                    if (groupof5 < 0)
                    {
                        groupof5 = 0;
                    }
                    groupof3 = (totalrobots - groupof5*5) / 3;
                }
                else
                {
                    groupof5 = totalrobots / 5-1;
                    if (groupof5 < 0)
                    {
                        groupof5 = 0;
                    }
                    groupof3 = (totalrobots - groupof5 * 5) / 3;
                }
                 
                if (groupof3 < 0)
                {
                    groupof3 = 0;
                }
                //исключительный случай для 6 и 7
                if (totalrobots ==6 || totalrobots ==7)
                {
                    groupof5 = 0;
                    groupof3 = 2;
                }

            } 
          public void LiveIsYear()
            {
                
                //создаем сообщества
                NewYearAssociation();
                //смещаем на год
                //ломаются через 3 года
                totalrobots -= dead3year;
                dead3year = dead2year;
                dead2year = dead1year;
                //собираем новых
                dead1year = groupof3 * 5 + groupof5 * 9;
                //добавляем вновь собраных
                totalrobots += dead1year;
            } 
        } 


    }
}
