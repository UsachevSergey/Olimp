using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.LONG_ARITHMETHIC
{
    //ДЛИНОЕ ЧИСЛО УМНОЖИТЬ НА КОРОТКОЕ
    class LongNumberMultiplyShortNumber
    {
        ///
        static string Exe(string firstNumber, int secondNumber)
        {
             //база по которой будем производить умножение
            const int baseint = 10;
            //масив результатирующих знаячений
            List<int> ArrayValue = new List<int>();

            //переводим строку в масив чисел
            for (int i = 0; i < firstNumber.Count(); i++)
            {
                ArrayValue.Add(int.Parse(firstNumber[i].ToString()));
            }
            //реверсируем чтобы сначала шли менее значимые числа
            ArrayValue.Reverse(); 
            //остаток
            int carry = 0;
            //поразрядно перемножаем
            for (int i = 0; i < ArrayValue.Count(); i++)
            { 
                long AN = carry + ArrayValue[i] * secondNumber;
                ArrayValue[i] = int.Parse((AN % baseint).ToString());
                carry = int.Parse((AN / baseint).ToString());
                //если последний и есть остаток
                if (ArrayValue.Count - 1 == i && carry > 0)
                {
                    ArrayValue.Add(0);
                }
            }
            //если есть остаток то вписываем его в перед числа
            if (carry > 0)
            {
                if (ArrayValue[ArrayValue.Count() - 1] > 0)
                {
                    ArrayValue.Add(carry);
                }
            }
            //убираем лидирующие нули
            while (ArrayValue.Last() == 0 && ArrayValue.Count > 1)
            {
                ArrayValue.RemoveAt(ArrayValue.Count - 1);
            }
            //выводим 
            string StrReturn = "";
            for (int i = ArrayValue.Count - 1; i >= 0; i--)
            {
                StrReturn+=ArrayValue[i];
            }
            return StrReturn; 
        }
    }
}
