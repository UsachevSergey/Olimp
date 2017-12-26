using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.TulaCodeCup2017.Final
{
    class GameWithNumbers
    {
        public static void X()
        {
            int COuntTest = int.Parse(Console.ReadLine());
            for (int i = 0; i < COuntTest; i++)
            {
                int CountCard = int.Parse(Console.ReadLine());
                List<int> CARD = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(a => int.Parse(a));
                int MAXa = 0;
                int MAXb = 0;
                int SummaA = 0;
                int SummaB = 0;
                for (int j = 0; j < CARD.Count; j += 3)
                {
                    int CuurentA = CARD[j];
                    int CuurentB = CARD[j + 1];
                    //если карта первого больше
                    if (CuurentA > CuurentB)
                    {
                        int min = Math.Min(CuurentA, CARD[j + 2]);
                        int max = Math.Max(CuurentA, CARD[j + 2]);
                        SummaA += min;
                        SummaB += CuurentB;

                        if (MAXa < min)
                        {
                            MAXa = min;
                        }
                        if (MAXb < CuurentB)
                        {
                            MAXb = CuurentB;
                        }


                    }

                    else
                    {
                        int min = Math.Min(CuurentB, CARD[j + 2]);
                        int max = Math.Max(CuurentB, CARD[j + 2]);
                        SummaB += min;
                        SummaA += CuurentA;

                        if (MAXb < min)
                        {
                            MAXb = min;
                        }
                        if (MAXa < CuurentA)
                        {
                            MAXa = CuurentA;
                        }
                    }

                }
                if (SummaA > SummaB)
                {
                    Console.WriteLine("Kolya");
                }
                else if (SummaB > SummaA)
                {
                    Console.WriteLine("Vova");
                }
                else
                {
                    if (MAXa > MAXb)
                    {
                        Console.WriteLine("Kolya");
                    }
                    else
                    {
                        Console.WriteLine("Vova");
                    }
                }


            }


        }
    }
}
