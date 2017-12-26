using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StairsMM
{ 
    public static void X()
    {
        int CountBox = int.Parse(Console.ReadLine());
        int MaxH  = 0;   
        //пока использовано меньше чем есть
       while (CountBox>0)
        {
            //если есть больше чем нужно на доп ряд
            if (CountBox>=MaxH+1)
            {
                MaxH++;
            }
            else
            {
                break;
            }
            CountBox -= MaxH; 
        }
        Console.WriteLine(MaxH);
    }
}
