using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class TwoSequence
    {
        public static void X()
        {
            int A =int.Parse(Console.ReadLine());
            List<int> ListA = new List<int>() { 2, 3, 4, 7, 13 }; 
            List<int> ListB = new List<int>() { 1, 5, 6, 8, 9, 10,11,12 };

            while (ListA.Count()<A)
            {
                //берем последний добавленый в масив а
                int LastInt = ListA.Last();
                ListA.Add(ListB[ListA.Count - 1] + ListB[ListA.Count - 3]); 
                //пока последний во втором списке не будет на 1 меньше последнего из первого списка заполнять второй список
                while (ListB.Last()!=ListA.Last()-1)
                {
                    LastInt++;
                    ListB.Add(LastInt);
                }
            }
            Console.WriteLine(ListA[A-1]+" "+ListB[A-1]);
        }
    }
}
