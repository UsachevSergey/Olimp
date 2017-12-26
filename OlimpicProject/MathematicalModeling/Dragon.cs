using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Dragon
    {
        public static void X()
        {
            string[] S = Console.ReadLine().Split(' ');
            int CountHead = int.Parse(S[0]); 
            int CountTail = int.Parse(S[1]);
            Drag D = new Drag();
            D.Head = CountHead;
            D.Tail = CountTail;
            int CoutnSwordToStrike = 0;
            bool end = false ;
            if (D.Head==0 && D.Tail==0)
            {
                end = true;
            }

            if (D.Tail == 0 && D.Head % 2 == 1)
            {//если нет хвостов то не получится сделать четное количество голов
                CoutnSwordToStrike = -1;
            }
            else {
                while (!end)
                {
                    CoutnSwordToStrike++;
                    //если  1 хвост то добавить 
                    if (D.Tail == 1)
                    {
                        end = D.SwordToStrike(1, "tail");
                    }
                    //если боьше 2 хвостов
                    else if (D.Tail > 2)
                    {
                        end = D.SwordToStrike(2, "tail");
                    }
                    //если осталось 2 хвоста  и нечетное количество голов то 
                    else if (D.Tail == 2 && D.Head % 2 == 1)
                    {
                        end = D.SwordToStrike(2, "tail");
                    }
                    else if (D.Tail == 2 && D.Head % 2 == 0)
                    {
                        end = D.SwordToStrike(1, "tail");
                    }
                    else
                    {
                        end = D.SwordToStrike(2, "head");
                    }

                }
            }
            Console.WriteLine(CoutnSwordToStrike);

        }

        public class Drag
        {
            public int Head, Tail;

            public bool VerifDead() {
                if (Head ==0 && Tail==0)
                {
                    return true;
                }
                return false;
            }


            public bool SwordToStrike(int count,string type)
            {
                //удар по голове 
                if (type=="head")
                {
                    if (count==1)
                    {
                        Head--; 
                        Head++;
                        return VerifDead();
                    }
                    else
                    {
                        Head--;
                        Head--;
                      return  VerifDead(); 
                    }
                }
                else
                {//по хвосту
                    if (count == 1)
                    {
                        Tail--; 
                        Tail++;
                        Tail++;
                        return VerifDead();
                    }
                    else
                    {
                        Tail--;
                        Tail--;
                        Head++; 
                        return VerifDead();
                    }
                }
            } 
        }



    }

}
