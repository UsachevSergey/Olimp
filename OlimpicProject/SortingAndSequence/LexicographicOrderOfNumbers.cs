using System; 
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class LexicographicOrderOfNumbers
    {
        public static void X()
        {

            string[] NK = Console.ReadLine().Split(' ');
            int CountNumber = int.Parse(NK[0]);
            int CountKumber = int.Parse(NK[1]);
            List<int> LS = new List<int>();
            for (int i = 0; i < CountNumber; i++)
            {
                LS.Add(i + 1);
            }
            ForSort FS = new ForSort();
            LS.Sort(FS);
           

            Console.WriteLine(LS.IndexOf(CountKumber)+1);
        }

        public class ForSort : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x==y)
                {
                    return 0;
                }
                else
                {

                    int min = Math.Min(x.ToString().Count(), y.ToString().Count());
                    string Xstr = x.ToString();
                    string Ystr = y.ToString();
                    for (int i = 0; i < min; i++)
                    {
                        //если очередная цифра первого меньше очередной цифры второго то второе число больше
                        if (Xstr[i] < Ystr[i])
                        {
                            return -1;
                        } else if (Xstr[i] > Ystr[i])
                        {
                            return 1;
                        }
                    }
                    //если первые N цифр оказались одинаковые то выводим с наименьшим количеством
                    if (Xstr.Count()==min)
                    {
                        return -1;
                    }
                    return 1;



                }
            }
        }
    }
}
