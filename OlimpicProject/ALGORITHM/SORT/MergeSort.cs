using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.SORT
{
    class MergeSort
    {
         

        //для запуска принимаем масив который нужно отсортировать и возвращаем уже отсортированый
        public int[] GO(int[] array)
        { 
           return array= Sort(array);
        }

        private int[] Sort(int[] arr)
        {
            //если нечего сортировать то возвращаем
            if (arr.Length==1)
            {
                return arr;
            }
            else
            {
                //получаем индекс середины масива
                int Middle = arr.Length / 2;

                //возвращаем слияние 2х масивом
                //первый отсортированый масив от 0 до разделителя
                //второй от разделителя до конца
                return Merge(
                    Sort(arr.Take(Middle).ToArray())
                    ,
                    Sort(arr.Skip(Middle).ToArray())); 
            } 
        }

        private int[] Merge(int[] arr1, int[] arr2)
        {
            int a = 0;int b = 0;
            //длина сливаемых масивов
            int len = arr1.Length + arr2.Length;
            //возвращаемый масив
            int[] Merg = new int[len];

            for (int i = 0; i < len; i++)
            {
                if (b<arr2.Length && a<arr1.Length)
                {
                    if (arr1[a]>arr2[b])
                    {
                        Merg[i] = arr2[b];
                        b++;
                    }
                    else
                    {
                        Merg[i] = arr1[a];
                        a++;
                    }
                }
                else if (b<arr2.Length)
                {
                    Merg[i] = arr2[b];
                    b++;
                }
                else
                {
                    Merg[i] = arr1[a];
                    a++;
                } 
            }
            //возвращаем слитый масив;
            return Merg;




        }
    }
}
