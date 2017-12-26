using System;
using System.Collections.Generic;

namespace OlimpicProject.IntegerArithmetic
{
    class Factorization
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            string result = "";

            //наполняем колекцию простых чисел
            List<int> PrimaryNumber = new List<int>() {2,3}; 
            for (int i =5 ; i < 50000; i+=2)
            {
                bool yes = true;
                for (int j = 0; j < PrimaryNumber.Count; j++)
                {
                    if (i% PrimaryNumber[j] == 0)
                    {
                        yes = false;
                        break; 
                    }
                }
                if (yes)
                {
                    PrimaryNumber.Add(i);
                }
            }

            while (true)
            {
                int sqrtN = (int)Math.Sqrt(N);
                bool yes = true;
                for (int i = 0; i < PrimaryNumber.Count; i++)
                {
                    if (N%PrimaryNumber[i]==0)
                    {
                        N = N / PrimaryNumber[i];
                        result += PrimaryNumber[i] + "*";
                        yes = false;
                        break;
                    }
                    //то число точно простое
                    if (PrimaryNumber[i]> sqrtN)
                    {
                        break;
                    } 
                }
                if (yes)
                {
                    if (N>1)
                    {
                        result += N;
                    }
                    break;
                     
                }
            }
            Console.WriteLine(result.Trim('*'));

        }

    }
}
