using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class PalindromeTime
    {
        public static void X() {
        List<int> t = Console.ReadLine().Split(':').ToList().ConvertAll(s => int.Parse(s));
        DateTime dt = new DateTime(1, 1, 1, t[0], t[1], 0);
         dt=   dt.AddMinutes(1);

            bool d = true;
            while (d)
            {
                string a = dt.Hour.ToString();
                string b = dt.Minute.ToString();
                if (a.Length==1)
                {
                    a = "0" + a;
                }
                if (b.Length==1)
                {
                    b = "0" + b;
                }

                

                if (a[0]==b[1] &&a[1]==b[0])
                {
                    d = false;
                    Console.WriteLine(a + ":" + b);
                    break; 
                } 
                else{

                    dt = dt.AddMinutes(1);
                }
            }
            
    }

    }
}
