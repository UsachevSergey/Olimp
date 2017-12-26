using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.RecursionOverkill
{
    class TwoPilesOfStones
    { 
        int CountStone = int.Parse(Console.ReadLine()); 
        List<int> Stones = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));

    }
}
