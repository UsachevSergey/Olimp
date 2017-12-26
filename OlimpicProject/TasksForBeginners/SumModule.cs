using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class SumModule
    {public static void X()
        {
            int Count = int.Parse(Console.ReadLine());
            List<int> listInteger = new List<int>();
            string[] str = Console.ReadLine().Split(); 
            for (int i = 0; i < Count; i++)
            {
                listInteger.Add(int.Parse(str[i]));
            }
            string res = "";
            int countres = 0;
            //если положительных больше
            if (listInteger.Sum()>=0)
            {
                for (int i = 0; i < listInteger.Count; i++)
                {

                    if (listInteger[i] > 0)
                    {
                        countres++;
                        res += i + 1 + " ";
                    }
                }
            }
            else
            {
                for (int i = 0; i < listInteger.Count; i++)
                {

                    if (listInteger[i] < 0)
                    {
                        countres++;
                        res += i + 1 + " ";
                    }
                }
            }
            Console.WriteLine(countres);
            res.Trim();
            Console.WriteLine(res);
        }
    }
}
