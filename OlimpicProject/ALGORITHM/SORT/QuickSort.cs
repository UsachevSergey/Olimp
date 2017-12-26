using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.SORT
{
    class QuickSort
    {


         int[] array;

        //для запуска принимаем масив который нужно отсортировать и возвращаем уже отсортированый
        public int[] GO(int[] array)
        {
            this.array = array;

            Sort(0, array.Count()-1);

            return this.array;

        }

        //принимает масив для сортировки
        //левую и правую границу
          void Sort(int Left, int Right)
        {
            //если левая граница менее правой
            if (Left < Right)
            {
                //маркер разделителя
                int Marker = Partation(Left, Right);
                //рекурсивно вызываем ешё раз сортировку 
                //от левого края до разделителя и от разделителя до правого края
                Sort(Left, Marker);
                Sort(Marker + 1, Right);
            }
        }

        //Разделить
        //Принимает масив левую и правую границу
        int Partation(int Start, int End)
        {
            //берем первый элемент
            int X = array[Start];

            //стартовую и конечную позицию -1(в дальнейшем на 1 шаге +-1)

            int I = Start - 1;
            int J = End + 1;

            while (true)
            {

                do
                {
                    J--;
                }
                while (array[J] > X);

                do
                {
                    I++;
                }
                while (array[I] < X);

                if (I <J)
                {
                    //меняем местами
                    int tmp = array[I];
                    array[I] = array[J];
                    array[J] = tmp;
                }
                else
                { return J; }
            }


        }

    }
}
