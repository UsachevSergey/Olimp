using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


//ПОПРОБОВАТЬ ЧЕРЕЗ SR.PEEK;


namespace OlimpicProject.SortingAndSequence
{
    class SortingCounting
    {
        public static void X()
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            //считываем
            int CountNumber = int.Parse(sr.ReadLine());
            // string  Numbers = sr.ReadLine().Replace("  "," ");
            //int countChar = Numbers.Count();

            Dictionary<short, short> DIC = new Dictionary<short, short>();

            //Заполняем крайними значениями
            for (short i = -101; i < 101; i++) { DIC.Add(i, 0); }

            //текущие для цикла
            string currentnumber = "";
            char currentchar = ' ';
            short a = 0;
            int countadd = 0;
            //пока не добавили всё что нужно
            while (countadd != CountNumber)
            {
                currentchar = (char)sr.Read();
                if (currentchar.ToString() == "\r")
                {
                    if (short.TryParse(currentnumber, out a))
                    {
                        DIC[a]++;
                        countadd++;
                        currentnumber = "";
                    }
                }
                else
                {
                    //если очередной символ пробел
                    if (currentchar.ToString() == " ")
                    {

                        if (short.TryParse(currentnumber, out a))
                        {
                            DIC[a]++;
                            countadd++;
                            currentnumber = "";
                        }
                    }
                    else
                    {
                        currentnumber += currentchar.ToString();
                    }
                }
            }


            //если в конце небыло пробела
            if (
                currentnumber == "\r" ||
                currentnumber == "\n")
            {
                DIC[short.Parse(currentnumber)]++;
            }


            foreach (var item in DIC)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    sw.Write(item.Key + " ");
                }

            }
            //переводим строку и закрываем файл
            sw.WriteLine();
            sw.Close();
            sr.Close();

        }
    }
}