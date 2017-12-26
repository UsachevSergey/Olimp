using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.LongArithmetic
{
    class AB
    {
        public static void X()
        {
            string S = Console.ReadLine().Trim(); 
            int N = int.Parse(Console.ReadLine());

            const int baseint = 10;
            List<int> ArrayValue = new List<int>();

            for (int i = 0; i < S.Count(); i++)
            {
                ArrayValue.Add(int.Parse(S[i].ToString()));
            }
            ArrayValue.Reverse();

             
                int carry = 0;
                for (int i = 0; i < ArrayValue.Count(); i++)
                {

                    long AN = carry + ArrayValue[i] * N;
                    ArrayValue[i] = int.Parse((AN % baseint).ToString());
                    carry = int.Parse((AN / baseint).ToString());
                    //если последний и есть остаток
                    if (ArrayValue.Count - 1 == i && carry > 0)
                    {
                        ArrayValue.Add(0);
                    } 
                }
                if (carry > 0)
                {
                    if (ArrayValue[ArrayValue.Count() - 1] > 0)
                    {
                        ArrayValue.Add(carry);
                    }
                } 
            //убираем лидирующие нули
            while ( ArrayValue.Last() == 0 && ArrayValue.Count>1)
            {
                ArrayValue.RemoveAt(ArrayValue.Count - 1);
            }

            //выводим
            
                for (int i = ArrayValue.Count - 1; i >= 0; i--)
                {
                    Console.Write(ArrayValue[i]);
                }
            
            Console.WriteLine();

        }
    }
}
