using System; 
using System.Linq; 

namespace OlimpicProject.TulaCodeCup2017.Round2
{
    class Coin
    {
        public static void X()
        {
            int CountTest = int.Parse(Console.ReadLine());
            for (int i = 0; i < CountTest; i++)
            {
                int CountCoins = int.Parse(Console.ReadLine());
                string currentrow = Console.ReadLine();
                if (CountCoins == 1)
                {
                    if (currentrow.Count(a => a.ToString() == "1") > 0)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                else
                {
                    if (currentrow.Count(a => a.ToString() == "0") == 1)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }
    }
}
