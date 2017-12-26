using System;
using System.Collections.Generic;
using System.Linq; 


class GopherAndDog
{
    public static void X()
    { 
        List<int> CoordGopher = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
        List<int> CoorDog = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
        int CountHole = int.Parse(Console.ReadLine());
        bool save = false;
        for (int i = 0; i < CountHole; i++)
        { 
            List<int> CoordHole = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));

            int lenghtX = Math.Abs(CoorDog[0] - CoordHole[0]);
            int lenghtY = Math.Abs(CoorDog[1] - CoordHole[1]);
            double LenghtHoleDog = Math.Sqrt(lenghtX * lenghtX + lenghtY * lenghtY)/2;
             
             lenghtX = Math.Abs(CoordGopher[0] - CoordHole[0]);
             lenghtY = Math.Abs(CoordGopher[1] - CoordHole[1]);
            double LenghtHoleGopher = Math.Sqrt(lenghtX * lenghtX + lenghtY * lenghtY);
            
            //если первому ближе чем второму
            if (LenghtHoleGopher<LenghtHoleDog)
            {
                Console.WriteLine(i+1);
                save = true;
                break;
            } 
        }

        if (!save)
        {
            Console.WriteLine("NO");
        }

    }

    


}