using System; 
using System.Linq; 

namespace OlimpicProject.RecursionOverkill
{
    class ladder
    {
        static int result = 0;
        public static void X()
        {
            int CountBox = int.Parse(Console.ReadLine());
            int[] a = new int[CountBox + 4];
            a[0] = 0;
            a[1] = 1;
            a[2] = 1;
            a[3] = 2;
            a[4] = 2;
            int[] ar = new int[25];
            for (int i = 1; i < 25; i++)
            {
                ar[i] = ar[i - 1] + i;
            }


            for (int i = 5; i < a.Count(); i++)
            {
                a[i]++;
                int max = i / 2;
                for (int f = 1; f < max; f++)
                {
                    a[i] += a[f];
                }
                a[i] += a[max];
                if (i % 2 == 0)
                {
                    a[i]--;
                } 
            }
            Console.WriteLine(a[CountBox]);
        }

    }
}
