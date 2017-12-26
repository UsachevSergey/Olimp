using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace OlimpicProject.TulaCodeCup2017.Round1
{
    class InterestingBiology
    {
        public static void X()
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();

            StreamWriter sw = new StreamWriter("output.txt");
            StreamReader sr = new StreamReader("input.txt");

            int Q = int.Parse(sr.ReadLine());

            for (int i = 0; i < Q; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                int curentCountShake = int.Parse(s[0].ToString());
                int CountCurentTest = int.Parse(s[1].ToString());
                List<int> ListShake = sr.ReadLine().Replace("  ", " ").Trim().Split(' ').OrderByDescending(a => a).OrderByDescending(a => a.Count()).ToList().ConvertAll(sdd => int.Parse(sdd));
                int currentres = 0;
                for (int j = 0; j < CountCurentTest; j++)
                {
                    //текущий минимальный вес
                    int curentMinW = int.Parse(sr.ReadLine());
                    //сразу добавляем те что больше или равны минимальному 
                    currentres = ListShake.Count(cx => cx >= curentMinW);
                    //уже съедено
                    int Eaten = 0; 
                    //проходим по всем 
                    for (int d = currentres; d < curentCountShake; d++)
                    {
                        //считаем сколько не хватает до откормки
                        int ForFull = curentMinW - ListShake[d];
                        //если в списке осталось больше или равно нужному то кормим.иначе рвем
                        //подсчет осталось = общее количество - текущий объект -уже съедены
                        if (ListShake.Count - (d + 1) - Eaten >= ForFull)
                        {
                            //добавляем еще змею 
                            currentres++;
                            //съедаем змей пошедших на  ̶x̶  корм
                            Eaten += ForFull;
                        }
                        else
                        {
                            break;
                        }
                    }
                    sw.WriteLine(currentres);
                    currentres = 0;
                }
            } 
            sw.Close();
            sr.Close();
            sWatch.Stop();
            Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
        }
    }
}
