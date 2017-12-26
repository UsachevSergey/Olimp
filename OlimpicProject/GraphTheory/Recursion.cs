using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GraphTheory
{
    class Recursion
    {
        public static void X()
        { 
            int CountProcedure = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[CountProcedure, CountProcedure];
            List<int> indexcurrent = new List<int>(); 
            for (int i = 0; i < CountProcedure; i++)
            {
                for (int j = 0; j < CountProcedure; j++)
                {
                    Matrix[i, j] = 99999;
                }
            }
            int lastproc = 0;
            Dictionary<string, int> Juxtaposive = new Dictionary<string, int>();
            
            for (int i = 0; i < CountProcedure; i++)
            {
                string nameproc = Console.ReadLine();
                //сопоставляем
                if (!Juxtaposive.ContainsKey(nameproc))
                {
                    Juxtaposive.Add(nameproc, lastproc);
                    lastproc++;
                }
                int numberprocedure = Juxtaposive.First(d => d.Key == nameproc).Value;
                indexcurrent.Add(numberprocedure);

                int CountSubProcedure = int.Parse(Console.ReadLine());
                for (int sub = 0; sub < CountSubProcedure; sub++)
                {
                    string currentSubProcedure = Console.ReadLine();
                    if (!Juxtaposive.ContainsKey(currentSubProcedure))
                    {
                        Juxtaposive.Add(currentSubProcedure, lastproc);
                        lastproc++;
                    } 
                    int numbersubprocedure = Juxtaposive.First(d => d.Key == currentSubProcedure).Value;
                    Matrix[numberprocedure, numbersubprocedure] = 1;
                }
                Console.ReadLine();  
            }//тут матрица процедур заполнена

            for (int k = 0; k < CountProcedure; k++)
            {
                for (int i = 0; i < CountProcedure; i++)
                {
                    for (int j = 0; j < CountProcedure; j++)
                    {
                        Matrix[i, j] = Math.Min(
                            Matrix[i,j],
                            Matrix[i,k]+Matrix[k,j]
                            );
                    }
                }
            }
            for (int i = 0; i < indexcurrent.Count; i++)
            {
                if (Matrix[indexcurrent[i], indexcurrent[i]] !=99999)
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
}
