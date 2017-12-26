using System; 

namespace OlimpicProject.RecursionOverkill
{
    class Fraction
    {
        public static void X()
        {
            long N = long.Parse(Console.ReadLine());
            long a = N / 2;
            long b = 0; 
            if (N % 2 != 0)
            {
                b = a + 1;
            }
            else
            {
                b = a;
                if (a % 2 == 0)
                {
                    a--;
                    b++;
                }
                else
                {
                    a -= 2;
                    b += 2;
                }
            }
            Console.WriteLine(a + " " + b);

        }
    }
}
