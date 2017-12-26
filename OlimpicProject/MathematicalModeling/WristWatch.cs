using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class WristWatch
    {

        public struct PatternNumber
        {
            public bool LeftUp, RightUp, LeftDown, RightDown, Up, Down, Center;
            public bool LeftUp2, RightUp2, LeftDown2, RightDown2, Up2, Down2, Center2;
            //проверка на загорание
            public void VerifyFire(int a)
            {
                switch (a)
                {
                    case 0: LeftUp = true; RightUp = true; LeftDown = true; RightDown = true; Up = true; Down = true; break;
                    case 8: LeftUp = true; RightUp = true; LeftDown = true; RightDown = true; Up = true; Down = true; Center = true; break;
                    case 1: RightUp = true; RightDown = true; break;
                    case 2: RightUp = true; LeftDown = true; Up = true; Down = true; Center = true; break;
                    case 3: RightUp = true; RightDown = true; Up = true; Down = true; Center = true; break;
                    case 4: LeftUp = true; RightUp = true; RightDown = true; Center = true; break;
                    case 5: LeftUp = true; RightDown = true; Up = true; Down = true; Center = true; break;
                    case 6: LeftUp = true; LeftDown = true; RightDown = true; Up = true; Down = true; Center = true; break;
                    case 7: RightUp = true; RightDown = true; Up = true; break;
                    case 9: LeftUp = true; RightUp = true; RightDown = true; Up = true; Down = true; Center = true; break;
                    default: break;
                }
            }
            //проверка на потухание
            public void VerifyNoFire(int a)
            {
                switch (a)
                {
                    case 0: Center2= true;break;
                    case 1: LeftUp2 = true;   LeftDown2 = true;   Up2 = true; Down2 = true; Center2 = true;break;
                    case 2: LeftUp2 = true;RightDown2 = true;break;
                    case 3: LeftDown2 = true;LeftUp2 = true;break;
                    case 4: Up2 = true;Down2 = true;LeftDown2 = true;break;
                    case 5:LeftDown2 = true;RightUp2 = true;break;
                    case 6: RightUp2 = true;break;
                    case 7:LeftDown2 = true;LeftUp2 = true;Center2 = true;Down2 = true;break;
                    case 8:break;
                    case 9: LeftDown2 = true;break;

                    default:LeftUp2=true; RightUp2=true; LeftDown2=true; RightDown2=true; Up2=true; Down2=true; Center2 = true; break;
                }
            }



            public bool AR()
            {
                if (LeftUp == true &&  RightUp == true &&  LeftDown == true &&  RightDown == true &&  Up == true &&  Down == true && Center==true  
                    && LeftUp2 == true &&  RightUp2 == true &&  LeftDown2 == true &&  RightDown2 == true &&  Up2 == true &&  Down2 == true &&  Center2 == true
                    )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


        public static void X()
        {
            string[] S = Console.ReadLine().Split(':');
            DateTime DT = new DateTime(1, 1, 1, int.Parse(S[0]), int.Parse(S[1]), 1);
            PatternNumber AHours = new PatternNumber();
            AHours.LeftUp = true;
            PatternNumber BHours = new PatternNumber();
            PatternNumber AMinutes = new PatternNumber();
            PatternNumber BMinutes = new PatternNumber();
            bool AllRight = false;
            int countMin = 0;
            while (!AllRight)
            {
                if (DT.Hour.ToString().Count() == 1)
                {
                    BHours.VerifyFire(DT.Hour); 
                    AHours.VerifyNoFire(99);
                    BHours.VerifyNoFire(DT.Hour);
                }
                else
                {
                    AHours.VerifyFire(int.Parse(DT.Hour.ToString()[0].ToString()));
                    BHours.VerifyFire(int.Parse(DT.Hour.ToString()[1].ToString()));
                    AHours.VerifyNoFire(int.Parse(DT.Hour.ToString()[0].ToString()));
                    BHours.VerifyNoFire(int.Parse(DT.Hour.ToString()[1].ToString())); 
                }

                if (DT.Minute.ToString().Count() == 1)
                {
                    BMinutes.VerifyFire(DT.Minute);
                    BMinutes.VerifyNoFire(DT.Minute);
                    AMinutes.VerifyNoFire(99);
                }
                else
                {
                    AMinutes.VerifyFire(int.Parse(DT.Minute.ToString()[0].ToString()));
                    BMinutes.VerifyFire(int.Parse(DT.Minute.ToString()[1].ToString()));
                    AMinutes.VerifyNoFire(int.Parse(DT.Minute.ToString()[0].ToString()));
                    BMinutes.VerifyNoFire(int.Parse(DT.Minute.ToString()[1].ToString()));
                }
                if (AHours.AR() &&BHours.AR() && AMinutes.AR() && BMinutes.AR())
                {
                    AllRight = true;
                }
                else
                {
                    countMin++;
                    DT = DT.AddMinutes(1);
                }
            }
            Console.WriteLine(countMin);


        }
    }
}
