using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class MaximumSubsequence
    {


        public static void X()
        {

           int n = int.Parse(Console.ReadLine());
            List<string> s = Console.ReadLine().Split(' ').ToList();
            s.RemoveAll(sda => sda == "");

           
                List<int> max_subenum = new List<int>();
                max_subenum.Add(1);
                for (int i = 1; i < n; i++)
                {
                    int current_max = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (int.Parse(s[i]) > int.Parse(s[j]) && current_max < max_subenum[j])
                        {
                            current_max = max_subenum[j];
                        }
                    }
                    max_subenum.Add(current_max + 1);
                }

                Console.WriteLine(max_subenum.Max());


            }

        }
    }
