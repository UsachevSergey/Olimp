using System;
using System.Collections.Generic; 

namespace OlimpicProject.RecursionOverkill
{
    class Kpermutation
    {

        static int result = 0;
        public static void X()
        {

            string[] s = Console.ReadLine().Split(' ');
            //максимальное число
            int N = int.Parse(s[0]);
            //максимальная разница
            int K = int.Parse(s[1]);

            List<int> L = new List<int>();
            for (int i = 0; i < N; i++)
            {
                L.Add(i + 1);
            }
            for (int i = 1; i < N+1; i++)
            {
                List<int> LI = new List<int>(L) ;
                LI.Remove(i);
                Perm(i, K,LI);
            }
            Console.WriteLine(result);
            
        }


        public static void Perm(int LastNumber,int K,List<int> List)
        {
            if (List.Count==0)
            {
                result++;
            }
            for (int i = 0; i < List.Count; i++)
            {
                if (Math.Abs(List[i]-LastNumber)<=K)
                {
                    List<int> newList = new List<int>(List);
                    int nextLast = List[i];
                    newList.RemoveAt(i);
                    Perm(nextLast, K, newList);
                }
            }
        }
    }
}
