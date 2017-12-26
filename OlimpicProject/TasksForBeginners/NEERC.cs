using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NEERC
{
public static void X()
    {
        int countunivers =int.Parse(Console.ReadLine());
        string[] S = Console.ReadLine().Split(' ');
        int CountHall= int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < countunivers; i++)
        {
            int currentcou = int.Parse(S[i]);
            //если в команде больше чем залов
            if (currentcou>CountHall)
            {
                result += CountHall;
            }
            else
            {
                result += currentcou;
            }
        }
        Console.WriteLine(result);

    }
}