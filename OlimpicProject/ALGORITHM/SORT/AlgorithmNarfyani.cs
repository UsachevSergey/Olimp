using System.Linq; 

/*
 * Алгоритм Наройаны
 * Находит следующее лексиграфическую перестановку введеного масива
 * например при вводе {1,2,1} выведет {2,1,1}
 * например при вводе {1,1,2} выведет {1,2,1}
 * например при вводе {1,2,3,4} выведет {1,2,4,3}
 * например при вводе {1,3,50,4} выведет {1,4,3,40} 
 * */

namespace OlimpicProject.ALGORITHM.SORT
{
    class AlgorithmNarfyani
    {

        int[] array;

        public int[] GO(int[] array)
        {
            this.array = array;  
            NextPermutation(); 
            return this.array;

        }
        /// <summary>
        /// Ищет следующую перестановку
        /// </summary>
        /// <returns></returns>
        public bool NextPermutation()
        {

            int j = array.Length - 1;

            //ищим наибольший j для которого a[j]<a[j-1]
            while (array[j - 1] >= array[j])
            {
                //если перестановка невозможна и этот элемент является последним лексиграфическим
                if (j < 2) { return false; }
                j--;
            }
            j--;

            int l = array.Length - 1;
            //ищем наибольщий l для которого a[l]>a[j]
            while (array[l] <= array[j])
            {
                l--;
            }

            //меняем местами элемент a[l] и элемент a[j] 
            _SwapItems(j, l);

            int lastindex = array.Count() - 1;

            j++;

            while (j < lastindex)
            {
                _SwapItems(j, lastindex);
                j++;
                lastindex--;
            }
            return true;
        }
        /// <summary>
        /// меняет в масиве 2 элемента местами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void _SwapItems(int a, int b)
        {
            int c = array[a];
            array[a] = array[b];
            array[b] = c;
        }





    }
}
