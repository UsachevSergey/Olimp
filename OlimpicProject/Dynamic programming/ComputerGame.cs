using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class ComputerGame
    {
        public static void X()
        {
            int CountPlatf = int.Parse(Console.ReadLine());
            List<string> ArrayPlatformf = Console.ReadLine().Split(' ').ToList();
            ArrayPlatformf.Remove(""); 
            List<int> ArrayPlatform = ArrayPlatformf.ToList().ConvertAll(df => int.Parse(df));

            int[] energy = new int[CountPlatf];
            if (CountPlatf>1)
            { 
            energy[0] = 0;
            energy[1] = Math.Abs(ArrayPlatform[1] - ArrayPlatform[0]);
            for (int i = 2; i < ArrayPlatform.Count; i++)
            { 
                energy[i] = Math.Min(energy[i-1]+Math.Abs(ArrayPlatform[i]-ArrayPlatform[i-1]),energy[i-2]+3*Math.Abs(ArrayPlatform[i]-ArrayPlatform[i-2]));
            }
            Console.WriteLine(energy[CountPlatf-1]);
                
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
