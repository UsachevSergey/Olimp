using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class AgainFibonach
    {
        public static void X()
        {
            long N = long.Parse(Console.ReadLine());
            List<long> period = new List<long>() {1,1,2}; 
            int every = 3;
            for (int i = 2; i < 300; i++)
            { 
                long current = period[period.Count - 1] + period[period.Count - 2]; 

                string a = current.ToString()[current.ToString().Length - 1].ToString();

                string b = period[period.Count - 1].ToString()[period[period.Count - 1].ToString().Count() - 1].ToString();

                if ( a == "1" && b=="1")
                {
                    every = i;
                } 
                period.Add(int.Parse(current.ToString()[current.ToString().Length-1].ToString())); 
            }
            int numberint =(int) N % every;
   
            Console.WriteLine(period[numberint]);
            
        }
    }
}
