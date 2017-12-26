using System; 
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class Anagram
    {
        public static void X()
        {

            string S = Console.ReadLine();
            int[] arr = new int[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                //записываем порядки чаров
                arr[i] = S[i];
            } 
            AlgorithmNarfya1ni an = new AlgorithmNarfya1ni(); 
            arr = an.GO(arr); 
            string result = "";
            for (int i = 0; i < arr.Count(); i++)
            {  result += Convert.ToChar(arr[i]).ToString();  }
            Console.WriteLine(result); 
        }
    }

    class AlgorithmNarfya1ni
    { 
        int[] array; 
        
        public int[] GO(int[] array)
        {
            this.array = array;
            NextPermutation();
            return this.array;

        } 


        public bool NextPermutation()
        { 

            int j = array.Length-1;

            //ищим наибольший j для которого a[j]<a[j-1]
            while (array[j-1]>=array[j])
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
        private void _SwapItems(int a, int b)
        {
            int c = array[a];
            array[a] = array[b];
            array[b] = c;
        } 
    }
}
