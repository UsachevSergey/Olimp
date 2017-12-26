using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Tourist
    {public static void X()
        {
            string[] S = Console.ReadLine().Split(' ');
            int MinCount = int.Parse(S[0]);
            int MaxWeight = int.Parse(S[1]);
            string[] S2 = Console.ReadLine().Split(' ');
            int capacity1 = int.Parse(S2[1]);
            int capacity2 = int.Parse(S2[3]);
            int capacity3 = int.Parse(S2[5]);
            int weight1 = int.Parse(S2[0]);
            int weight2 = int.Parse(S2[2]); 
            int weight3 = int.Parse(S2[4]);

            if ( (capacity1>=MinCount&& weight1<=MaxWeight )||
                (capacity2 >= MinCount && weight2 <= MaxWeight)||
                (capacity3 >= MinCount && weight3 <= MaxWeight)||
                (capacity1 + capacity2 + capacity3 >= MinCount && weight1 + weight2 + weight3 <= MaxWeight) ||
                (capacity1 + capacity2  >= MinCount && weight1 + weight2  <= MaxWeight) ||
                (capacity1 + capacity3  >= MinCount && weight1  + weight3 <= MaxWeight) ||
                ( capacity2 + capacity3 >= MinCount && weight2 + weight3 <= MaxWeight) 
                )
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
