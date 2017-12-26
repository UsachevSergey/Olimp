using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GraphTheory
{
    class Banquet
    {
        public static void X()
        {

            string[] inp = Console.ReadLine().Split(' ');
            int CountHuman = int.Parse(inp[0]);
            int CountPair  = int.Parse(inp[1]);
            List<int> Table1 = new List<int>(); 
            List<int> Table2 = new List<int>();
            List<pair> ListPair = new List<pair>();
            

            for (int i = 0; i < CountPair; i++)
            {
                string[] currentstr = Console.ReadLine().Split(' ');
                ListPair.Add(new pair()
                {
                    h1 = int.Parse(currentstr[0]),
                    h2 = int.Parse(currentstr[1]) 
            });
            }
            bool yes = true;
            if (CountPair > 0)
            {
                //рассаживаем первых несовместимых
                Table1.Add(ListPair[0].h1);
                Table2.Add(ListPair[0].h2);
                ListPair.RemoveAt(0); 

                while (ListPair.Count > 0)
                {
                    bool NoAdd = true;
                    //идем по всем парам и смотрим кого куда можно посадить
                    for (int i = 0; i < ListPair.Count; i++)
                    {
                        int hum1 = ListPair[i].h1;
                        int hum2 = ListPair[i].h2;
                        //если человек уже посажен  за этот стол то его не трогать 
                        //а пробовать посадить второго за второй стол

                        //если стол содержит и 1 и 2
                        if (
                           (Table1.Contains(hum1) && Table1.Contains(hum2)) ||
                           (Table2.Contains(hum1) && Table2.Contains(hum2))
                            )
                        {
                            //значит рассодить нельзя
                            yes = false;
                            ListPair = new List<pair>();
                            break;
                        }
                        else if (Table1.Contains(hum1))
                        {
                            if (!Table2.Contains(hum2))
                            {
                                Table2.Add(hum2);
                                NoAdd = false;
                                ListPair.RemoveAt(i); i = 999;
                            }
                        }
                        else if (Table2.Contains(hum1))
                        {
                            if (!Table1.Contains(hum2))
                            {
                                Table1.Add(hum2);
                                NoAdd = false;
                                ListPair.RemoveAt(i); i = 999;
                            }
                        }
                        else if (Table1.Contains(hum2))
                        {
                            if (!Table2.Contains(hum1))
                            {
                                Table2.Add(hum1);
                                NoAdd = false;
                                ListPair.RemoveAt(i); i = 999;
                            }
                        }
                        else if (Table2.Contains(hum2))
                        {
                            if (!Table1.Contains(hum1))
                            {
                                Table1.Add(hum1);
                                NoAdd = false;
                                ListPair.RemoveAt(i); i = 999;
                            }
                        }
                    }

                    if (NoAdd &&ListPair.Count>0)
                    {//если за весь цикл не смогли никого добавить значит
                     //в предыдущих нету конфликтующих с новыми парами
                     //поэтому добавляем первого встречного

                        //обнуляем чтоб в дальнейшем не просматривать тех кто никак не свчязан
                        Table1 = new List<int>();
                        Table2 = new List<int>();
                        Table1.Add(ListPair[0].h1);
                        Table2.Add(ListPair[0].h2);
                        ListPair.RemoveAt(0);
                    }
                }
            }
            if (yes)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
              
        }
        class pair{
          public  int h1, h2;
        }
    }
}
