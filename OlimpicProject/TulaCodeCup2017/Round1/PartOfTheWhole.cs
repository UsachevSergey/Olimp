using System;

namespace OlimpicProject.TulaCodeCup2017.Round1
{
    class PartOfTheWhole
    {
       
        public static void X()
        {
            //количество тестов
            long CountTest = long.Parse(Console.ReadLine());
            //идем по всем тестам
            for (long i = 0; i < CountTest; i++)
            {
                string[] s = Console.ReadLine().Replace("  "," ").Trim().Split(' ');
                //переводим в координаты змеи А
                long ax1 = long.Parse(s[0]);
                long ay1 = long.Parse(s[1]);
                long ax2 = long.Parse(s[2]);
                long ay2 = long.Parse(s[3]);
                string[] s2 = Console.ReadLine().Replace("  ", " ").Trim().Split(' ');
              //переводим в координаты змеи B
                long bx1 = long.Parse(s2[0]);
                long by1 = long.Parse(s2[1]);
                long bx2 = long.Parse(s2[2]);
                long by2 = long.Parse(s2[3]); 
                 


                //если в одной прямой
                if (ax1 == ax2 && bx1 == bx2 && ax1 == bx1 && ax2 == bx2 ||
                    ay1 == ay2 && by1 == by2 && ay1 == by1 & ay2 == by2)
                {
                    //вертикаль
                   if (ax1 == ax2 && bx1 == bx2 && ax1 == bx1)
                    {
                        //1 змея
                        long A = ay1;
                        long B = ay2; 
                        //2 змея
                        long C = by1;
                        long D = by2; 
                        //считаем сумму
                        //сумма двух змей
                        long summsh = Math.Abs(A - B) + 2 + Math.Abs(C - D);
                        //растояние от минимальной  до максимальной точки
                        long Lenght2snake = Math.Abs(Math.Min(A, Math.Min(B, Math.Min(C, D))) - Math.Max(A, Math.Max(B, Math.Max(C, D)))) + 1;
                        //еслисумма отрезков больше растояния от минимального до максимального
                        // и одна не входит во вторую
                        if (summsh > Lenght2snake && Lenght2snake!= Math.Abs(A - B) && Lenght2snake != Math.Abs(C - D))
                        {
                            Console.WriteLine("yes");
                        }
                        else
                        {
                            Console.WriteLine("no");
                        }
                    }
                    else
                    {
                        long A = ax1;
                        long B = ax2;
                        long C = bx1;
                        long D = bx2;
                        long summsh = Math.Abs(A - B) + 2 + Math.Abs(C - D);
                        long Lenght2snake = Math.Abs(Math.Min(A, Math.Min(B, Math.Min(C, D))) - Math.Max(A, Math.Max(B, Math.Max(C, D)))) + 1;
                        //еслисумма отрезков больше растояния от минимального до максимального
                        // и общая одна змея не входит во вторую
                        if (summsh > Lenght2snake  && Lenght2snake != Math.Abs(A - B) && Lenght2snake != Math.Abs(C - D))
                        {
                            Console.WriteLine("yes");
                        }
                        else
                        {
                            Console.WriteLine("no");
                        }
                    }

                } 
                else //если в разных прямых
                { 
                    //если точка то не дойдет
                    //ищем общую точку (oна может быть только концом отрезка)
                    if ( 
                        ax1 == bx1 && ay1 == by1  ||
                         ax1 == bx2 && ay1 == by2 ||
                         ax2 == bx2 && ay2 == by2 ||
                         ax2 == bx1 && ay2 == by1
                         )
                    {

                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
