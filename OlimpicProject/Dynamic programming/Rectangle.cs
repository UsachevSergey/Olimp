using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rectangle
{
    public static void X()
    {
        //XOIOX изучить вопрос по поводу получения формулы
        string[] s = Console.ReadLine().Split();
        ulong H = ulong.Parse(s[0]);
        ulong W = ulong.Parse(s[1]);
        ulong Result = H * (H + 1) * W * (W + 1) / 4;
        Console.WriteLine(Result);
    }

}
