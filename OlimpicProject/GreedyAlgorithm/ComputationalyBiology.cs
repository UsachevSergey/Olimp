using System; 

namespace OlimpicProject.GreedyAlgorithm
{
    class ComputationalyBiology
    {
        public static void X()
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            int indexA = 0;
            int indexB = 0;
            //пока индексы не превышают длину строкиы
            while (indexA<A.Length && indexB<B.Length)
            {
                if (B[indexB]==A[indexA])
                {
                    indexA++;
                } 
                //индекс второй всегда повышаем
                indexB++;
            }

            //если индекс достиг размера строки то все буквы были в последовательности б
            if (A.Length == indexA)
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
