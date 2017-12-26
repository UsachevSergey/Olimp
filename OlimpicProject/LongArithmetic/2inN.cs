using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.LongArithmetic
{
    class _2inN
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());

            const int baseint = 10;
            List<int> ArrayValue = new List<int>();

            ArrayValue.Add(2);

            for (int x = 1; x < N; x++)
            {
                int carry = 0;
                for (int i = 0; i < ArrayValue.Count(); i++)
                {

                    long AN = carry + ArrayValue[i] * 2;
                    ArrayValue[i] = int.Parse((AN % baseint).ToString());
                    carry = int.Parse((AN / baseint).ToString());
                    //если последний и есть остаток
                    if (ArrayValue.Count - 1 == i && carry > 0)
                    {
                        ArrayValue.Add(0);
                    }
                    if (x == 999 && i == ArrayValue.Count - 1)
                    {
                        int d = 1;
                    }
                }
                if (carry > 0)
                {
                    if (ArrayValue[ArrayValue.Count() - 1] > 0)
                    {
                        ArrayValue.Add(carry);
                    }
                }
            }
            //убираем лидирующие нули
            while (ArrayValue.Last() == 0)
            {
                ArrayValue.RemoveAt(ArrayValue.Count - 1);
            }

            //выводим

            if (N > 0)
            {
                for (int i = ArrayValue.Count - 1; i >= 0; i--)
                {
                    Console.Write(ArrayValue[i]);
                }
            }
            else {

                Console.Write(1);
                    }
            Console.WriteLine();
        }
    }
}
