using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Fishmans
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int CountFishMan = int.Parse(s[0]);
            int Remainder = int.Parse(s[1]);

            bool DivisionSuccessfull = true;
            //текущая куча рыбы
            int X = 1;
            //куча рыбы меняющаяся каждый цикл
            int curentX = 1;
            //пока успешно не разделено
            while (DivisionSuccessfull)
            {
                curentX = X;
                for (int i = 0; i < CountFishMan; i++)
                {  
                    //если при деление остаток нужный то продолжаем
                    if (curentX%CountFishMan==Remainder)
                    { 
                        //уменьшаем оставшеюся рыбу
                        curentX = curentX - (curentX / CountFishMan) - Remainder;
                        //если это последнее разделение то закончить цикл
                        if (i == CountFishMan - 1)  
                        {
                            DivisionSuccessfull = false;
                            break;
                        }
                    }
                    else
                    {
                        X++;
                        break;
                    }  
                } 
            } 
            Console.WriteLine(X);
        }
    }
}
