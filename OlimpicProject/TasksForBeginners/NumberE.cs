using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class NumberE
    {
        public static void X()
        {
            
           int n = int.Parse(Console.ReadLine());  
                string e = "7182818284590452353602875";
                string result = "2.";
                if (n > 0)
                {
                    result += e.Substring(0, n - 1);
                    if (n < 25)
                    {
                        //после выводимого
                        int last = int.Parse(e.Substring(n, 1));
                        if (last < 5)
                        {
                            result += e.Substring(n - 1, 1);
                        }
                        else
                        {
                            string dop = (int.Parse(e.Substring(n - 1, 1)) + 1).ToString();
                            result += dop;
                        }
                    }
                    else
                    {
                        result += "5";
                    }
                }
                else
                {
                    result = "3";
                }
                Console.WriteLine(result);

            

        }
    }
}
