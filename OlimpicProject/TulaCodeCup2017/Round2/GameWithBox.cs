using System;
using System.Collections.Generic; 
using System.Linq; 

///НЕ ХВАТАЕТ ВРЕМЕНИ..НУЖНО ОПТИМИЗИРОВАТЬ
namespace OlimpicProject.TulaCodeCup2017.Round2
{
    class GameWithBox
    {
        public static void X()
        {
            int CountComand = int.Parse(Console.ReadLine()) * 2;
            List<int> tower = new List<int>();
            int result = 0;
            for (int i = 0; i < CountComand; i++)
            {
                string currentComand = Console.ReadLine().Replace("  ", " ");
                if (currentComand.Contains("add"))
                {
                    tower.Add(int.Parse(currentComand.Split()[1]));
                }
                else
                {
                    if (tower.Last() == tower.Min())
                    {
                        tower.RemoveAt(tower.Count - 1);
                    }
                    else
                    {
                        result++;
                        tower = tower.OrderByDescending(a => a).ToList();
                        //убираем последний
                        tower.RemoveAt(tower.Count - 1);
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
