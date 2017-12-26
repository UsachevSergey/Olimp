using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class Gods
    {public  static void X()
        {
            int CountGod = int.Parse(Console.ReadLine());
            List<string> ListGod = new List<string>();
            int[] result = new int[CountGod];
            for (int i = 0; i < CountGod; i++)
            {
                ListGod.Add(Console.ReadLine());
            }
            //псевдобоги
            int CountImaginaryGod = int.Parse(Console.ReadLine());
            List<string> ListImaginaryGod = new List<string>();
            for (int i = 0; i < CountImaginaryGod; i++)
            {
                ListImaginaryGod.Add(Console.ReadLine());
            }

            //пройти по всем псевдобогам и если подозрительно
            //похож на бога тоесто с 1 ошибкой то добавить
            for (int i = 0; i < CountImaginaryGod; i++)
            {
                string currentImaginaryGod = ListImaginaryGod[i];
                for (int j = 0; j < ListGod.Count; j++)
                {
                    string currentGod = ListGod[j];
                    int counterror = 0;
                    //если одинаковая длина имен
                    if (currentGod.Length== currentImaginaryGod.Length)
                    {
                        //пройти и проверить буквы
                        for (int k = 0; k < currentGod.Length; k++)
                        {
                            if (currentGod[k]!=currentImaginaryGod[k])
                            {
                                counterror++;
                                if (counterror!=1)
                                {
                                    break;
                                }
                            }
                        } 
                    }
                    if (counterror==1)
                    {
                        result[j]++;
                    } 
                } 
            }
            string r = "";
            for (int i = 0; i < result.Count(); i++)
            {
                r += result[i]+" ";
            }
            r.Trim();
            Console.WriteLine(r);


        }
    }
}
