using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace OlimpicProject.Combinatorics
{
    class CollectingLables
    {

        public static void X()
        {
            
           // System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
           // swatch.Start();  
            StreamReader sr = new StreamReader("input216.txt");
            StreamWriter sw = new StreamWriter("output216.txt");
            int CountAlbum = int.Parse(sr.ReadLine());
            List<int> Albums = sr.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            int result = 0;
            Albums = Albums.OrderByDescending(x => x).ToList();
            bool end = false;

            //будем начинать с последнего и идти к первому для простоты удаления элемента из масива
            int indexmin = Albums.Count - 1;
            int indexmax = 0; 
            while (!end)
            {
                if (Albums.Count==1 
                    || Albums[indexmax] ==0 
                    || Albums[indexmin] == 0
                     )
                {
                    end = true;
                    break;
                }  

                    Albums[indexmax]--;
                    Albums[indexmin]--;

                //двигаем максимальный индекс
                //если максимальный стоит первым  
                if (indexmax == 0)
                {
                    //то проверить больше ли он второо
                    if (Albums[indexmax] < Albums[indexmax + 1])
                    {
                        indexmax++;
                    }//если больше то оставляем как есть либо двигаем маркер 
                }
                else
                {//если индекс не нулевой 

                    //то проверить больше ли следующее число
                    if (indexmax+1<Albums.Count&& Albums[indexmax + 1] > Albums[indexmax])
                    {//если больше  т двигаем маркер вперед
                        indexmax++;
                    }
                    else
                    {
                        //иначе  ставим маркер в 0
                        indexmax = 0;
                    }
                }



                //если минимальный равен 0 то убирам его
                if (Albums[indexmin] == 0)
                {
                    Albums.RemoveAt(indexmin);
                    indexmin--;
                }
                //если попали в 1 индекс пересчитать сортировку и убрать нули
                if (indexmax == indexmin)
                {
                    Albums = Albums.OrderByDescending(x => x).ToList();
                     indexmin = Albums.Count - 1;
                     indexmax = 0; 
                }






                result++;
            }

            //выводим

             
             

            sw.WriteLine(result);
            //swatch.Stop();

            //Console.WriteLine(swatch.Elapsed);
            sr.Close();
            sw.Close();

        }
    }
}
