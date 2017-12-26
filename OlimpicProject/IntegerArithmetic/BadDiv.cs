using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class BadDiv
    {
        public static void X()
        {
            //переводим сразу в масив цифр
            char[] s = Console.ReadLine().ToCharArray();
            //количество нулей в конце делителя
            int result_zero = 0;
            //считаем нули.если последняя цифра = 0 то в делитель добавляем 0
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[s.Count() - 1 - i].ToString() == "0")
                { result_zero++; }
                else
                { i = s.Count(); }
            }
            //наихудшим делителем является 1 с n нулями.
            //так как сумма его цифр = 1 и оно будет наивысшим среди делителей
            string result = "1";
            for (int i = 0; i < result_zero; i++)
            { result += "0"; }
            Console.WriteLine(result);
        }
    }
}
