using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BuyTicket
{
    public static void X()
    {
        int CountHuman = int.Parse(Console.ReadLine());
         
        int[] Result = new int[CountHuman];
        List<H> ArrayHuman = new List<H>();

        for (int i = 0; i < CountHuman; i++)
        {
            string[] currents = Console.ReadLine().Split();
            H currenth = new H() { p1 = int.Parse(currents[0]), p2 = int.Parse(currents[1]), p3 = int.Parse(currents[2]) };
            ArrayHuman.Add(currenth); 
        }

        Result[0]=ArrayHuman[0].p1;
        if (CountHuman > 1)
        {
            Result[1] = Math.Min(ArrayHuman[1].p1 + Result[0], ArrayHuman[0].p2);

            if (CountHuman > 2)
            {
                //или мас покупает или передает вперед
                Result[2] = Math.Min(ArrayHuman[2].p1 + Result[1], Math.Min(ArrayHuman[1].p2 + Result[0], ArrayHuman[0].p3));


                for (int i = 3; i < CountHuman; i++)
                {
                    //смотрим сколько можно получить если в очереди только и человек

                    Result[i] = Math.Min(ArrayHuman[i].p1 + Result[i - 1], Math.Min(ArrayHuman[i - 1].p2 + Result[i - 2], ArrayHuman[i - 2].p3 + Result[i - 3]));

                } 
            }
        }
        Console.WriteLine(Result[CountHuman - 1]);


    }
    class H
    {
        public int p1, p2, p3;
    }

}