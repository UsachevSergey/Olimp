using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class Decrypt
    {
        public static void X()
        {
            string StartString = Console.ReadLine();
            string BasePattern = "0123456789ABCDEFGHIJKLMNOPQ";
            string EndPattern =  "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            List<int> PositionDate = new List<int>();
            //проходим по строке и переводим в цифры
            for (int i = 0; i < StartString.Count(); i++)
            {
                //получаем позицию в базовом шаблоне
                int CurrentNumb = BasePattern.IndexOf(StartString[i].ToString());
                PositionDate.Add(CurrentNumb - i - 2);
            }

            string RESULT = "";
            //избавляемся от отрицательных 
            for (int i = 0; i < PositionDate.Count; i++)
            {
                while (PositionDate[i]<0)
                {
                    PositionDate[i] += 27;
                }
                RESULT += EndPattern[PositionDate[i]];
            }
            RESULT = RESULT.ToLower();
            Console.WriteLine(RESULT);
             




        }
    }
}
