using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.SORT
{
    class SortingCounting
    {

        //принимает на входе колекцию чисел
        public string SORT(List<int> LINT)
        {
            Dictionary<int, int> DIC = new Dictionary<int, int>();

            for (int i = 0; i < LINT.Count; i++)
            { 
                //если уже занесен в библиотеку
                if (DIC.ContainsKey(LINT[i]))
                {
                    //увеличиваем количество текущего элемента
                    DIC[LINT[i]]++;
                }
                else
                {
                    DIC.Add(LINT[i], 1);
                }
            }
            string Result = "";
            foreach (var item in DIC.OrderBy(a => a.Key))
            {
                for (int i = 0; i < item.Value; i++)
                {
                  Result+= item.Key + " ";
                } 
            }
            return Result;



        }


    }
}
