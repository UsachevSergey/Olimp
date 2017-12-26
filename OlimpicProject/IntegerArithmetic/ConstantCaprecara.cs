using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class ConstantCaprecara
    {
        public static void X()
        {
            string s = Console.ReadLine();
            string etalon = s;
            int result = 0;
            for (int i = 0; i < 9999; i++)
            {
                while (s.Count() != 4)
                {
                    s = "0" + s;
                }

                int[] arr_cifr = new int[4]; // массив по возрастанию
                arr_cifr[0] = Convert.ToInt32(s[0].ToString());
                arr_cifr[1] = Convert.ToInt32(s[1].ToString());
                arr_cifr[2] = Convert.ToInt32(s[2].ToString());
                arr_cifr[3] = Convert.ToInt32(s[3].ToString());
                for (int j2 = 0; j2 < 4; j2++)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        if (arr_cifr[j] > arr_cifr[j - 1])
                        {// сортировка по возрастанию
                            int p = arr_cifr[j - 1];
                            arr_cifr[j - 1] = arr_cifr[j];
                            arr_cifr[j] = p;
                        }
                    }
                }


                int ch_1 = Convert.ToInt32(arr_cifr[0].ToString() + arr_cifr[1].ToString() + arr_cifr[2].ToString() + arr_cifr[3].ToString());
                int ch_2 = Convert.ToInt32(arr_cifr[3].ToString() + arr_cifr[2].ToString() + arr_cifr[1].ToString() + arr_cifr[0].ToString());
                s = (ch_1 - ch_2).ToString();
                if (s == etalon)
                {
                    result = i;
                    i = 9999;
                }
                else
                {
                    etalon = s;
                } 
            }//endfor
            Console.WriteLine(etalon);
            Console.WriteLine(result);

        }
    }
}
