using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.Dynamic_programming
{ 
    class Agents
    {
        public static void X()
        {
            long CountAgent = long.Parse(Console.ReadLine().Trim());
            string[] s = Console.ReadLine().Replace("  ", " ").Trim().Split(); 
            
            List<A> ListAgents = new List<A>();
            
                for (long i = 0; i < CountAgent * 2+10; i += 2)
                {
                    try
                    {
                        ListAgents.Add(new A() { Age = long.Parse(s[i]), Danger = long.Parse(s[i + 1]) });
                    }
                    catch { i--; } // тут не все подходят из за этого неверный ответ (при неверном откатываем назад на 1)
                } 
            ListAgents = ListAgents.OrderBy(ss => ss.Age).ToList();


            long[] RS = new long[CountAgent]; 
                //сразу вписываем первую
                RS[1] = ListAgents[1].Danger; 
            if (CountAgent==2)
            {
                Console.WriteLine(RS[1]);
            }else
            if (CountAgent > 2)
            {
                RS[2] = ListAgents[2].Danger + RS[1];
                //проверяем кого выгодней соединить начиная с третьего до дпоследнего
                for (int i = 3; i < CountAgent ; i++)
                {
                    try
                    {
                        RS[i] = Math.Min(RS[i - 2], RS[i - 1]) + ListAgents[i].Danger;
                    }
                    catch { Console.WriteLine("sdd"); } 
                    } 
                    Console.WriteLine(RS[CountAgent - 1]); 
                }
        }
        class A
        {
            public long Age, Danger;
        }
    }
}
