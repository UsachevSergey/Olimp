using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Matrix
    {
        public static void X()
        {
            
            string[] s = Console.ReadLine().Split();
            int CountMatrix = int.Parse(s[0]);
            int SizeMatrix = int.Parse(s[1]);
            string[] IJ = Console.ReadLine().Split();
            int InterestedI = int.Parse(IJ[0]);
            int InterestedJ = int.Parse(IJ[1]);
            int MaxValueMatrix = int.Parse(Console.ReadLine());
            int[] StrMatrixA = new int[SizeMatrix];
            Console.ReadLine();

            //запрашиваем нужную строку первичную мтрицу
            for (int i = 0; i < SizeMatrix; i++)
            {
                if (i + 1 == InterestedI) { 
                string[] currentstr = Console.ReadLine().Replace("  ", " ").Trim().Split();
                    for (int j = 0; j < SizeMatrix; j++)
                    {
                        StrMatrixA[j] = int.Parse(currentstr[j]);
                    }
                }
                else { Console.ReadLine(); }
            }

            for (int cm = 1; cm < CountMatrix; cm++)
            {
                Console.ReadLine(); //пустая строка
                                    //создаем нужный столбец и заполняем его из входных данных 
                int[] ColMatrixB = new int[SizeMatrix];

                for (int i = 0; i < SizeMatrix; i++)
                {
                    string currentstr = Console.ReadLine();
                    for (int j = 0; j < SizeMatrix; j++)
                    {
                        ColMatrixB[j] = (ColMatrixB[j]+int.Parse(currentstr.Split()[j]) * StrMatrixA[i])%MaxValueMatrix;
                        
                    }
                } 
                StrMatrixA = ColMatrixB;
            } 
        Console.WriteLine(StrMatrixA[InterestedJ - 1]);
        


}
}
}
