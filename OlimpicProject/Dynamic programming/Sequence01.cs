using System;
using System.Collections.Generic;
using System.Linq; 
namespace OlimpicProject.Dynamic_programming
{
    class Sequence01
    {
        public static void X()
        {
            //номер элемента который надо вывести
            int Number = int.Parse(Console.ReadLine());
            //масив элементов
            string[] ArrayResult = new string[1000];
            //первый элемент равен или 1 или 0
            ArrayResult[0] = "2";
            ArrayResult[1] = "3";
             //заполняем масив элементов
            for (int i = 2; i < 1000; i++)
            {    
                ArrayResult[i] = Plus(ArrayResult[i-1],ArrayResult[i-2]); 
            }
            Console.WriteLine(ArrayResult[Number-1]);

        }


        static string Plus(string FirstNumber, string SecondNumber)
        {
            int NumberBase = 1000000000;
            int carry = 0;
            //первое число
            List<int> ListNumberFirst = new List<int>();
            List<int> ListNumberSecond = new List<int>();
            //пройти по числу и перевести в масив


            for (int q = FirstNumber.Length; q > 0; q -= 9)
            {

                if (q < 9)
                {
                    ListNumberFirst.Add(int.Parse(FirstNumber.Substring(0, q)));
                }
                else
                {

                    ListNumberFirst.Add(int.Parse(FirstNumber.Substring(q - 9, 9)));
                }

            }
            for (int q = SecondNumber.Length; q > 0; q -= 9)
            {
                if (q < 9)
                {
                    ListNumberSecond.Add(int.Parse(SecondNumber.Substring(0, q)));
                }
                else
                {

                    ListNumberSecond.Add(int.Parse(SecondNumber.Substring(q - 9, 9)));
                }
            }


            //складываем
            for (int x = 0; x < Math.Max(ListNumberFirst.Count, ListNumberSecond.Count); x++)
            {
                if (ListNumberFirst.Count == x)
                {
                    ListNumberFirst.Add(0);
                }

                carry = carry + ListNumberFirst[x] + (ListNumberSecond.Count > x ? ListNumberSecond[x] : 0);
                ListNumberFirst[x] = carry % NumberBase;
                carry = carry / NumberBase;

            }
            if (carry == 1)
            {
                ListNumberFirst.Add(1);
            }

            FirstNumber = "";
            //переводим колекцию в строку
            for (int y = ListNumberFirst.Count - 1; y >= 0; y--)
            {
                string add = ListNumberFirst[y].ToString();
                while (add.Length != 9)
                {
                    add = "0" + add;
                }

                FirstNumber += add;
            }

            FirstNumber = FirstNumber.TrimStart('0');

            if (FirstNumber == "")
            {
                FirstNumber = "0";
            }


            return FirstNumber;


        }

    }
}
