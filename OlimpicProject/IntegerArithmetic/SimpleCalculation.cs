using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class SimpleCalculation
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            int Number = int.Parse(s[0]);
            int Notation = int.Parse(s[1]);
            //переводим в нужную систему счисления
            string NumberInNotation = "";
            while (Number>=Notation)
            {
                NumberInNotation += Number % Notation;
                Number /= Notation;
            }
            if (Number != 0)
            {
                NumberInNotation += Number;
            }
            int sum = 0;
            int composition = 1;

            for (int i = 0; i < NumberInNotation.Length; i++)
            {
                int currentint =int.Parse(NumberInNotation[i].ToString());
                sum += currentint;
                composition *= currentint;
            }
            int result = composition - sum;
            Console.WriteLine(result);

        }
    }
}
