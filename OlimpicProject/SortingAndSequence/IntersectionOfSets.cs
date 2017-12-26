using System;
using System.Collections.Generic; 
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class IntersectionOfSets
    {
        public static void X()
        { 
            string fict = Console.ReadLine();
            List<string> q1 = Console.ReadLine().Split().ToList();
            List<string> q2 = Console.ReadLine().Split().ToList();
            List<string> intersect = q1.Intersect(q2).ToList();
            scaaii aa = new scaaii();
            intersect.Sort(aa); 
            foreach (var item in intersect)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine(); 
        }

        class scaaii : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (x == y)
                {
                    return 0;
                } 
                else if (x.Count() != y.Count()) {

                    if (x.Count() == Math.Min(x.Count(), y.Count()))
                    {
                        return -1;
                    }
                    return 1;
                }
                else
                    for (int i = 0; i < Math.Min(x.Count(), y.Count()); i++)
                    {
                        char Xchar = x[i];
                        char Ychar = y[i];
                        if (Xchar > Ychar)
                        {
                            return 1;
                        }
                        else if (Xchar < Ychar)
                        {
                            return -1;
                        }
                    } 
                return 1;
            }
        }

    }
}
