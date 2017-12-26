using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Delivery
{
    public static void X()
    {
        int CountType = int.Parse(Console.ReadLine());
        List<int> coins = Console.ReadLine().Split().ToList().ConvertAll(sd => int.Parse(sd));
        int MaxSum = int.Parse(Console.ReadLine());
        int[] results = new int[MaxSum + 1];

        //проходим по всем суммам  
        for (int i = 1; i < MaxSum + 1; i++)
        {
            int MinCoins = 999999999;
            //проходим по всем наминалам
            for (int z = 0; z < CountType; z++)
            {

                if (i == coins[z])
                {//если текущий номинал равен нужной сумме
                    MinCoins = 1;
                    break;
                }
                else if (coins[z] < i)
                {
                    //  если текущий номинал меньше проверяемой суммы
                    MinCoins = Math.Min(MinCoins, results[i - coins[z]] + 1);
                }
            } 
            results[i] = MinCoins;
        }
        if (results[MaxSum] == 999999999)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(results[MaxSum]);
        }
    }
}