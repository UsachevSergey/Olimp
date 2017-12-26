using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class PostulateOfBertran
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> A = new List<int>();
            int n2 = N * 2;
            for (int i = 2; i < n2; i++)
            {
                A.Add(i);
            }

            List<int> ListBasic = new List<int>();
            while (A.Count > 0)
            {
                int first = A.First();
                ListBasic.Add(first );
                A.RemoveAll(x => x % first == 0); 
            }
            int result = 0;
            for (int i = 0; i < ListBasic.Count; i++)
            {
                if (ListBasic[i]>N && ListBasic[i]<n2)
                {
                    result++;
                }
            } 
            Console.WriteLine(result);

        }
    }
}
