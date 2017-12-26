using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class PoleVaulting
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int CountSportsMan = int.Parse(s[0]);
            int CurentNumberSportsMan = int.Parse(s[1]);
            bool end = false;
            int numberloss = 0;
            if (CurentNumberSportsMan == 1)
            {
                Console.WriteLine(CountSportsMan);
            }
            else
            {
                while (!end)
                {
                    //если четный то выбывает в этом туре
                    if (CurentNumberSportsMan % 2 == 0)
                    {
                        numberloss += CurentNumberSportsMan / 2;
                        end = true;
                    }
                    else
                    {//не выбывает в текущем туре

                        //выбывает в текущем туре  половина тех что было и добавляется в выбывших
                        numberloss += CountSportsMan / 2;
                        //текущий номер становится в 2 раза меньше +1
                        CurentNumberSportsMan = (CurentNumberSportsMan / 2) + 1;

                        //если было четное количество участников то осталось ровно в 2 раза меньши иначе на 1 больше чем в 2 раза меньше
                        if (CountSportsMan%2==0)
                        {
                            CountSportsMan /= 2;
                        }
                        else
                        {
                            CountSportsMan /= 2;
                            CountSportsMan++;
                        } 
                    }
                } 
                Console.WriteLine(numberloss);
            }


        }
    }
}