using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class SimplificationsOfNumbers
    {
        public static void X()
        {
            int counttest = int.Parse(Console.ReadLine());
            string pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < counttest; i++)
            { 
                int CurrentNumber = int.Parse(Console.ReadLine());
                List<string> CurrentResult = new List<string>() {"0","0"};
                List<int> CurrentCriterion = new List<int>() {0,0}; 
                //проходим по всем системам счисления и заполняем критерии
                for (int ss = 2; ss < 37; ss++)
                {

                    List<int> currentNumberInNumberSystem = new List<int>();
                    int numb = CurrentNumber;
                    while (numb>ss-1)
                    {
                        currentNumberInNumberSystem.Add(numb % ss);
                        numb = numb / ss;
                    }
                    currentNumberInNumberSystem.Add(numb);
                    //количество различных символов
                    CurrentCriterion.Add(currentNumberInNumberSystem.Distinct().Count());

                    if (ss==36)
                    {
                        int f = 1;
                    }
                    string currentresult = "";
                    for (int cc = currentNumberInNumberSystem.Count-1; cc >= 0 ; cc--)
                    {
                        currentresult += pattern[currentNumberInNumberSystem[cc]];
                    }
                    //смотрим что меньше различных символов или количесво
                    CurrentCriterion[ss] += currentresult.Count();
                    //добавляем текущую строку в результат
                    CurrentResult.Add(currentresult); 
                }
                int minCrit = 99999;
                int indexmincrit = 9999;
                for (int d = 2; d < 37; d++)
                {
                    if (CurrentCriterion[d]<minCrit)
                    {
                        minCrit = CurrentCriterion[d];
                        indexmincrit = d;
                    }
                }
                Console.WriteLine(indexmincrit+" "+CurrentResult[indexmincrit]);

            }


        }
    }
}
