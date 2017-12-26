using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Bowling
    {
        public static void X()
        {
            int CountShot = Convert.ToInt32(Console.ReadLine()); 
            string[] CountShotDown = Console.ReadLine().Split(' ');
            int Strike = 0;
            int Spare = 0; 
            int pred_udar = 0;
            int Double_strike = 0;
            bool new_part = true;
            int numbr_part = 0;
            bool d = false;
            int[] ArrayShot = new int[CountShot]; 

            //пройти по всем ударам
            for (int i = 0; i < CountShot; i++)
            {
                //если новая партия
                if (new_part)
                {
                    numbr_part++;
                }
                int CurrentShotDown = Convert.ToInt32(CountShotDown[i]);

                ArrayShot[i] = CurrentShotDown;

                if (new_part && numbr_part == 10 && CurrentShotDown == 10)
                {
                    d = true;
                } 
                //если предыдущий был страйком то в предыдущий добавить  текущий удар
                if (Strike == 2 && numbr_part < 12)
                {
                    ArrayShot[i - 1] += CurrentShotDown;
                }
                //если страйк был 2 удара назад
                if (Strike == 1)
                {
                    ArrayShot[i - 2] += CurrentShotDown;
                }
                //если был спар
                if (Spare == 1 && numbr_part < 11)
                {
                    ArrayShot[i - 1] += CurrentShotDown;
                }
                if (Double_strike == 1)
                {
                    ArrayShot[i - 2] += CurrentShotDown;
                } 
                if (CurrentShotDown == 10 && new_part)
                {
                    if (Strike == 2)
                    {
                        Double_strike = 2;
                    }
                    Strike = 3;
                    new_part = true;
                }
                else if (!new_part && CurrentShotDown + pred_udar == 10)
                {
                    Spare = 2;
                    new_part = true;
                }
                else if (new_part)
                {
                    new_part = false;
                }
                else if (!new_part)
                {
                    new_part = true;
                } 
                Spare--;
                Strike--;
                pred_udar = CurrentShotDown;
                Double_strike--;
            } 
            int SumShot = ArrayShot.Sum();
            if (d)
            {
                SumShot = SumShot - ArrayShot[CountShot - 1] - ArrayShot[CountShot - 2];
            }
            Console.WriteLine(SumShot);
        }
    }
}
