using System; 

namespace OlimpicProject.GraphTheory
{
    class Construction
    {
        public static void X()
        {
            string[] CountSoldAndPAir = Console.ReadLine().Split(' ');
            int CountSold = int.Parse(CountSoldAndPAir[0]); 
            int CountPair = int.Parse(CountSoldAndPAir[1]);
            int[,] Matrix = new int[CountSold, CountSold];
            int infinity = 999999;
            for (int i = 0; i < CountSold; i++)
            {
                for (int j = 0; j < CountSold; j++)
                {
                    Matrix[i, j] = infinity;
                }
            } 
            for (int i = 0; i < CountPair; i++)
            { 
                string[] currentpair = Console.ReadLine().Split(' ');
                int I = int.Parse(currentpair[0])-1;
                int J = int.Parse(currentpair[1])-1;
                Matrix[I, J] = 1;
            }

            for (int k = 0; k < CountSold; k++)
            {
                for (int i = 0; i < CountSold; i++)
                {
                    for (int j = 0; j < CountSold; j++)
                    {
                        Matrix[i, j] = Math.Min(Matrix[i, j],
                            Matrix[i, k] + Matrix[k, j]
                            );
                    }
                }
            }
            bool yes = true;
            for (int i = 1; i < CountSold; i++)
            {
                if (Matrix[i,i]!=infinity)
                {
                    yes = false;
                    break;
                }
            }
            if (yes)
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
