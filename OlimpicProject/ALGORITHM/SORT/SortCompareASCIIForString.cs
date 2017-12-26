using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.SORT
{
    class SortCompareASCIIForString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            //если строки равны
            if (x == y)
            {
                return 0;
            }

            else
                //проходим посимвольно до минимальной длины слов
                //и на каждом шаге проверяем какой символ меньше среди двух.
                for (int i = 0; i < Math.Min(x.Count(), y.Count()); i++)
                {
                    
                    char Xchar = x[i];
                    char Ychar = y[i];
                    //символ из перой строки больше символа из второй стояшего на той же позиции
                    if (Xchar > Ychar)
                    {
                        //возвращаем что X>Y
                        return 1;
                    }
                    else if (Xchar < Ychar)
                    {
                        return -1;
                    }
                }
            //еСЛИ ПРИ ЦИКЛЕ НЕ ОПРЕДЕЛИЛОСЬ НАИМЕНЬШЕЕ.Т.Е. ОДНО СЛОВО ЯВЛЯЕТСЯ ЧАСТЬЮ ВТОРОГО
            //ТО ВЫВОДИМ НАИМЕНЬШЕЕ ПО ДЛИНЕ  
            if (x.Count() == Math.Min(x.Count(), y.Count()))
            {
                return -1;
            }
            return 1;
        }
    }
}
