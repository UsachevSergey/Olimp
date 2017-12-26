using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.LONG_ARITHMETHIC
{
    class NumberMinusNumber
    {

        static string Minus(string NumberFirst, string NumberSecond)
        {
            //вычисляем какое число длинее
            //дописываем нули так чтобы числа были одинаковой длины
            int MaxLenghtNumber = Math.Max(NumberFirst.Count(), NumberSecond.Count());
            NumberFirst = NumberFirst.PadLeft(MaxLenghtNumber, '0');
            NumberSecond = NumberSecond.PadLeft(MaxLenghtNumber, '0');

            bool minus = false;
            //уменьшаемое
            string reducing = NumberFirst;
            //вычитаемое
            string subtrahend = NumberSecond;
            //проходим по всем цифрам и смотрим какое число меньше
            //если первое меньше то в ответ дописываем минус
            for (int i = 0; i < MaxLenghtNumber; i++)
            {
                int Cfirst = int.Parse(NumberFirst[i].ToString());
                int Csecond = int.Parse(NumberSecond[i].ToString());


                if (Cfirst > Csecond)
                {
                    break;
                }
                else if (Cfirst < Csecond)
                {
                    reducing = NumberSecond;
                    subtrahend = NumberFirst;
                    minus = true;
                    break;

                }
            }

            //масив уменьшаемого
            List<int> ArrayReducing = new List<int>();
            //масив вычитаемого
            List<int> ArraySubtrahend = new List<int>();
            int NumberBase = 1000000000;

            for (int q = MaxLenghtNumber; q > 0; q -= 9)
            {

                if (q < 9)
                {
                    ArrayReducing.Add(int.Parse(reducing.Substring(0, q)));
                    ArraySubtrahend.Add(int.Parse(subtrahend.Substring(0, q)));
                }
                else
                {
                    ArrayReducing.Add(int.Parse(reducing.Substring(q - 9, 9)));
                    ArraySubtrahend.Add(int.Parse(subtrahend.Substring(q - 9, 9)));
                }

            }




            //займы
            int Carry = 0;
            for (int i = 0; i < ArrayReducing.Count; i++)
            {
                //вычитаем
                ArrayReducing[i] -= Carry + ArraySubtrahend[i];
                //если занимали то добавляем в заем
                Carry = ArrayReducing[i] < 0 ? 1 : 0;
                if (Carry == 1)
                {
                    ArrayReducing[i] += NumberBase;
                }
            }

            string result = "";
            bool rez = true;

            for (int y = ArrayReducing.Count - 1; y >= 0; y--)
            {
                string add = ArrayReducing[y].ToString();

                add.PadLeft(9, '0');
                result += add;
            }
            //убираем лидирующие
            result = result.TrimStart('0');


            //дописываем минус если ответ отрицательный
            if (minus)
            {
                result = "-" + result;
            }
            if (result == "")
            {
                result = "0";
            }
            return result;
        }

    }
}
