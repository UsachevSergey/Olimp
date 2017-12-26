using System; 
using System.Linq; 

namespace OlimpicProject.RecursionOverkill
{
    class Deletion
    {
        public static void X()
        {
            string S = Console.ReadLine();
            bool[] booldel = new bool[1000];

            for (int i = 0; i < S.Count() - 2; i++)
            {
                for (int j = i+1; j < S.Count() - 1; j++)
                {
                    for (int t = j+1; t < S.Count(); t++)
                    {
                        booldel[int.Parse(S[i].ToString() + S[j].ToString() + S[t].ToString())] = true;
                    }
                }
            } 
        int result = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (booldel[i])
                {
                    result++;
                }
            }

        Console.WriteLine(result); 
        }
}
}
