using System;

namespace OlimpicProject.MathematicalModeling
{
    class GameToStone
    {
        public static void X()
        {

            //суть задачи сводится к тому сможет ли второй игрок срастить так чтобы в конце на его ходе осталась 1

            bool yes = false;
            long n = long.Parse(Console.ReadLine());
            if (n == 1)
            {
                yes = true;
            }
            else if (n == 0)
            {
                yes = false;
            }
            else
            {

                while (n > 2)
                {
                    long sqrtk = (long)Math.Sqrt(n);
                    //квадрат корней
                    long SQ2 = (sqrtk * sqrtk);
                    if (n == SQ2)
                    {
                        break;
                    }
                    n -= sqrtk + 1;
                }
                //если в остатке от этих делений осталась 1 то выиграл
                if (n == 1 || n > 2)
                {
                    yes = true;
                }
            }
            Console.WriteLine(yes ? "WIN" : "LOSE");


        }
    }
}