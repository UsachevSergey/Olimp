using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Combinatorics
{
    class Patterns
    {
        public static void X()
        {
            string PatternOne = Console.ReadLine();
            string PatternTwo = Console.ReadLine();
            string Standart = "abcdefg"; 
            int[] arr = new int[PatternOne.Count()];


            //пройти по введеным шаблонам
            for (int i = 0; i < PatternOne.Count(); i++)
            {

                //первый
                int[] FirstOverplay;
                if (PatternOne[i].ToString() == "?")
                {//добавляем все возможные
                    FirstOverplay = new int[10];
                    for (int v1 = 0; v1 < 10; v1++)
                    {
                        FirstOverplay[v1] = v1;
                    }
                }
                else if (Standart.IndexOf(PatternOne[i].ToString()) > -1)
                { //если символ является буквой то допустимы 4 символа 
                    FirstOverplay = new int[4]; 
                    for (int v2 = 0; v2 < 4; v2++)
                    { 
                        FirstOverplay[v2] = v2 + Standart.IndexOf(PatternOne[i].ToString());
                    }
                }
                else
                {//если цифра
                    FirstOverplay = new int[1];
                    FirstOverplay[0] = Convert.ToInt32(PatternOne[i].ToString());
                }

                //второй 
                int[] SecondOverplay;
                if (PatternTwo[i].ToString() == "?")
                {//любой символ
                    SecondOverplay = new int[10];
                    for (int v1 = 0; v1 < 10; v1++)
                    {
                        SecondOverplay[v1] = v1;
                    }
                }
                else if (Standart.IndexOf(PatternTwo[i].ToString()) > -1)
                {
                    //добавляются 4 символа 
                    SecondOverplay = new int[4];
                    for (int v2 = 0; v2 < 4; v2++)
                    {
                        SecondOverplay[v2] = v2 + Standart.IndexOf(PatternTwo[i].ToString());
                    }
                }
                else
                {
                    //добавляет сам себя
                    SecondOverplay = new int[1];
                    SecondOverplay[0] = Convert.ToInt32(PatternTwo[i].ToString());
                }


                //считаем количество совпадений по текущему символу
                int CountOverplay = 0;
                //пройти по текущим данным
                for (int z = 0; z < FirstOverplay.Count(); z++)
                {
                    //если во втором содержится такойже символ что и в первом то добавляем 1 в результат
                    if (SecondOverplay.Contains(FirstOverplay[z]))
                    {
                        CountOverplay++;
                    }
                }
                arr[i] = CountOverplay;
            }


            int result = 1;
            //результатом будет перемножение всех доступных значений
            for (int i = 0; i < PatternOne.Count(); i++)
            {
                result *= arr[i];
            } 
            Console.WriteLine(result); 
        }
    }
}
