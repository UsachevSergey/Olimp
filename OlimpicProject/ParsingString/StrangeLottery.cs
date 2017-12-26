using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class StrangeLottery
    {
        public static void X()
        {
            //получаем строку
            string S = Console.ReadLine();
            //показатель удаения
            bool del = false;
            //проходим по текущей строке
            for (int i = 0; i < S.Count() - 1; i++)
            {
                //если цифра меньше следующей то удаляем её
                int a = int.Parse(S[i].ToString());
                int b = int.Parse(S[i + 1].ToString());
                if (a < b)
                {
                    S = S.Remove(i, 1);
                    del = true;
                    i = S.Count();
                }
            }
            //если за цикл не нашел что можно удалить то удаляет последнюю
            if (!del)
            {
                S = S.Remove(S.Count() - 1, 1);
            }
            //повторяется предыдущий цикл
            del = false;
            for (int i = 0; i < S.Count() - 1; i++)
            {
                int a = int.Parse(S[i].ToString());
                int b = int.Parse(S[i + 1].ToString());
                if (a < b)
                {
                    S = S.Remove(i, 1);
                    del = true;
                    i = S.Count();
                }
            }
            if (!del)
            {
                S = S.Remove(S.Count() - 1, 1);
            }

            Console.WriteLine(S);



        }
    }
}
