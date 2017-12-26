using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Sum
    {
        public static void X()
        {
            
            ushort CountNumbers = ushort.Parse(Console.ReadLine());
            List<ushort> Numbers   = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(assa => ushort.Parse(assa));
            
                List<ushort> result = new List<ushort>();
            result.Add(0);
            Numbers.Sort();
            bool[] b = new bool[50001];
            b[0] = true;
            //проходим по всем добавляемым числам и складываем их с результатами
            //которые были и если такого результата ещё не было то добавляем в коллекцию результатов
            for (ushort i = 0; i < CountNumbers; i++)
            {
                ushort Countresult = (ushort)result.Count ;
                for (ushort h = 0; h < Countresult; h++)
                { 
                  ushort currentsum = (ushort)(Numbers[i] + result[h]);
                    if (!b[currentsum])
                    {
                        result.Add(currentsum);
                        b[currentsum] = true;
                    } 
                }
            } 
            Console.WriteLine(result.Count);
            

        }
    }
}
