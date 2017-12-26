using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Numbers
    {
        public static void X()
        {
            string InputString = Console.ReadLine();
            int maxsumm = -999999;
            for (int i = 0; i < InputString.Count(); i++)
            {
                int current_summ = 0;
                //в текущей строке удаляем i символ  
                string current_S = InputString.Remove(i, 1);
                //складываем все четные
                for (int j = 0; j < current_S.Count(); j += 2)
                {
                    current_summ += Convert.ToInt32(current_S[j].ToString());
                }
                //вычитаем все нечетные
                for (int j = 1; j < current_S.Count(); j += 2)
                {
                    current_summ -= Convert.ToInt32(current_S[j].ToString());
                }
                if (current_summ > maxsumm)
                {
                    maxsumm = current_summ;
                }
            }
            Console.WriteLine(maxsumm);
        }
    }
}
