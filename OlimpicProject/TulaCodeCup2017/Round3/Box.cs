using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TulaCodeCup2017.Round3
{
    class Box
    {

        struct Board
        {
            public int S1, S2;
        }

        public static void X()
        {
            int counttes = int.Parse(Console.ReadLine());
            for (int i = 0; i < counttes; i++)
            {
                List<Board> BS = new List<Board>();
                List<int> size = new List<int>();
                for (int k = 0; k < 6; k++)
                {
                    string[] currnrb = Console.ReadLine().Replace("  ", " ").Trim().Split();
                    int A = int.Parse(currnrb[0]);
                    int B = int.Parse(currnrb[1]);
                    BS.Add(new Board()
                    {
                        S1 = Math.Min(A, B),
                        S2 = Math.Max(A, B)
                    });
                    size.Add(A);
                    size.Add(B);
                }
                //если размеров больше чем может быть
                if (size.Distinct().Count() > 3)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    //сортируем по размерам
                    BS = BS.OrderBy(d => d.S1).ThenBy(d => d.S2).ToList();

                    if (BS[0].S1 == BS[1].S1 && BS[0].S2 == BS[1].S2
                        &&
                        BS[2].S1 == BS[3].S1 && BS[2].S2 == BS[3].S2
                        &&
                        BS[4].S1 == BS[5].S1 && BS[4].S2 == BS[5].S2
                        )
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }

            }
        }
    }
}
