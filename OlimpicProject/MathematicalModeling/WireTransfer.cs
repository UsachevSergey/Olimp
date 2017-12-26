using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class WireTransfer
    {public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            bool itsnsover = true;
            int transfer = 0;
            int tax = 0;
            //пока есть деньги вычитать из них
            while (itsnsover)
            {
                //если есть деньги на налог и ещё чучуть
                if (N>7)
                {
                    //списываем на налог
                    N -= 7;
                    tax += 7;
                    //если осталось больше 100 то списываем 100 иначе списываем весь остаток
                    if (N>=100)
                    {
                        N -= 100;
                        transfer += 100;
                    }
                    else
                    {
                        transfer += N;
                        N = 0;
                    }
                }
                else
                {
                    itsnsover = false;
                }
            }
            Console.WriteLine(transfer+" "+tax);
        }
    }
}
