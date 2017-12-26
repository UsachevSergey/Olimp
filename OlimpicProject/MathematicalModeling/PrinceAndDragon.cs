using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrinceAndDragon
{
    public static void X()
    {
        string[] s = Console.ReadLine().Split(' ');
        int PowerSword = Convert.ToInt32(s[0]);
        int TotalHead = Convert.ToInt32(s[1]);
        int Regeneration = Convert.ToInt32(s[2]);


        int result = 0;
        //если голов больше чем удар меча и востановление больше или равно удару то бесконечно
        if (TotalHead - PowerSword > 0 && Regeneration >= PowerSword)
        {

        }
        else
        {
            //пока есть головы
            while (TotalHead > 0)
            {
                //срезаем голову
                TotalHead = TotalHead - PowerSword;
                if (TotalHead <= 0)
                {
                    result++;
                }
                else
                {
                    result++;
                    //если есть головы то востанавливаем 
                    TotalHead += Regeneration;
                }
            }
        }
        string R = result.ToString();
        if (R == "0")
        {
            R = "NO";
        }
        Console.WriteLine(R);


    }

}