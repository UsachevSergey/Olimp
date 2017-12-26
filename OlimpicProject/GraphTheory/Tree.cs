using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Tree
    {
        public static void X()
        {

            int Size = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[Size,Size];
            int CountEdge = 0;
            for (int i = 0; i < Size; i++)
            {
                string[] CurrentStr = Console.ReadLine().Split(' ');
                for (int j = 0; j < Size; j++)
                {
                    Matrix[i,j]=CurrentStr[j]=="0"?99999:int.Parse(CurrentStr[j]);
                    if (Matrix[i, j]==1)
                    {
                        CountEdge++;
                    }
                }
            }
            CountEdge /= 2;

            for (int k = 0; k < Size; k++)
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        Matrix[i, j] = Math.Min(Matrix[i, j], Matrix[i, k] + Matrix[k, j]);
                    }
                }
            } 
            string result = "YES";
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (Matrix[i,j]==99999)
                    {
                        result = "NO";
                        break;
                    }
                    
                }
            }  
            if (Size==1)
            {
                result = "YES";
            }

            if (Size-1!=CountEdge)
            {
                result = "NO";
            }

            Console.WriteLine(result);



        }
    }
}
