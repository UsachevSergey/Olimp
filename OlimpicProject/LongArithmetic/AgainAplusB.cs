using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.LongArithmetic
{
    class AgainAplusB
    {
        public static void X()
        {
            //List<char> A = Console.ReadLine().ToCharArray().ToList();
            //List<char> B = Console.ReadLine().ToCharArray().ToList();

            //A.Reverse();
            //B.Reverse();

            //int carry = 0;
            //for (int i = 0; i < Math.Max(A.Count(), B.Count()); i++)
            //{
            //    if (i==A.Count())
            //    {
            //        A.Add('0');
            //    }
            //    carry = int.Parse(A[i].ToString()) + carry + (B.Count > i ? int.Parse(B[i].ToString()) : 0);
            //    A[i] =  (carry %10).ToString().ToCharArray()[0];
            //    carry = carry / 10;
            //}
            //if (carry==1)
            //{
            //    A.Add('1');
            //}
            //for (int i = A.Count-1; i>=0; i--)
            //{
            //    Console.Write(A[i].ToString());
            //}
            //Console.WriteLine( );



            string AAA = Console.ReadLine();
            string BBB = Console.ReadLine();
            int NumberBase = 1000000000;
            int carry = 0;
            //первое число
            List<int> NumberA = new List<int>();
            List<int> NumberB = new List<int>();
            //пройти по числу и перевести в масив


            for (int q = AAA.Length; q > 0; q -= 9)
            {

                if (q < 9)
                {
                    NumberA.Add(int.Parse(AAA.Substring(0, q)));
                }
                else
                {

                    NumberA.Add(int.Parse(AAA.Substring(q - 9, 9)));
                }

            }
            for (int q = BBB.Length; q > 0; q -= 9)
            {
                if (q < 9)
                {
                    NumberB.Add(int.Parse(BBB.Substring(0, q)));
                }
                else
                {

                    NumberB.Add(int.Parse(BBB.Substring(q - 9, 9)));
                }
            }


            //складываем
            for (int x = 0; x < Math.Max(NumberA.Count, NumberB.Count); x++)
            {
                if (NumberA.Count == x)
                    {
                        NumberA.Add(0);
                    }

                    carry = carry + NumberA[x] + (NumberB.Count > x ? NumberB[x] : 0);
                    NumberA[x] = carry % NumberBase;
                    carry = carry / NumberBase;
                
            }
            if (carry == 1)
            {
                NumberA.Add(1);
            }


            AAA = "";

            for (int y = NumberA.Count - 1; y >= 0; y--)
            {
                string add = NumberA[y].ToString();
                while (add.Length != 9)
                {
                    add = "0" + add;
                }

                AAA += add;
            }

            AAA = AAA.TrimStart('0');

            if (AAA == "")
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(AAA);
            }


        }
    }
}
