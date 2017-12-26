using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Roads
{
    public static void X()
    {
        int CountTown = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < CountTown; i++)
        {
            string currentstring = Console.ReadLine();
            result+=currentstring.Count(a=>a=='1');
        }
        Console.WriteLine(result/2);
    }

}