using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class Poker
    {
        public static void X()
        {
            List<int> Card = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));


            Card.Sort();
            //храним перечень карт
            List<int> Dis = new List<int>();
            Dis = Card.Distinct().ToList();
            //если все карты одинаковы
            if (Dis.Count()==1 )
            {
                Console.WriteLine("Impossible");
            }
            else if (Dis.Count()==2)
            {
                //если одна из карт встречается 4 раза
                if (Card.Count(a=>a==Dis[0])==4 || Card.Count(a => a == Dis[1]) == 4)
                {
                    Console.WriteLine("Four of a Kind");
                }
                else
                {
                    Console.WriteLine("Full House");
                } 
            }
            else if (Dis.Count()==3)
            {
                //если есть карта встречающаяся 3 раза
                if (
                    Card.Count(a => a == Dis[0]) == 3 || 
                    Card.Count(a => a == Dis[1]) == 3 ||
                    Card.Count(a => a == Dis[2]) == 3 )
                {
                    Console.WriteLine("Three of a Kind");
                }
                else
                {
                    Console.WriteLine("Two Pairs");
                }
            }
            else if(Dis.Count()==4)
            {
                Console.WriteLine("One Pair");
            }
            else
            {
                //если 4 подряд
                if (Dis.Max()-Dis.Min() ==4)
                {
                    Console.WriteLine("Straight");
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
            }
            


        }
    }
}
