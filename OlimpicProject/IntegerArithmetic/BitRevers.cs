using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class BitRevers
    {
        public static void X()
        {
            int A =int.Parse(Console.ReadLine());
            //переводим в двоичную
            string indouble = Convert.ToString(A, 2);
            List<char> indoublerevers = indouble.Reverse().ToList();
            indouble = "";
            foreach (var item in indoublerevers)
            {
                indouble += item;
            }
            //переводим из двоичной
            int result = Convert.ToInt32(indouble,2);
            Console.WriteLine(result);

        }
    }
}
