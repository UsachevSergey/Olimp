using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class MaxMinOneNumber
    {
        public static void X()
        {
            string S = Console.ReadLine();
            List<int> ListNumber = new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                ListNumber.Add(int.Parse(S[i].ToString()));
            } 
            ListNumber = ListNumber.OrderByDescending(a => a).ToList();
            string Max = "";
            for (int i = 0; i < ListNumber.Count; i++)
            {
                Max += ListNumber[i];
            } 
            ListNumber =ListNumber.OrderBy(a=>a).ToList();
            int index = 0;
            while (ListNumber[0]==0)
            {
                if (ListNumber[index]>0)
                {
                    ListNumber[0] = ListNumber[index];
                    ListNumber[index] = 0;
                }
                index++;
            }
            string Min = "";
            for (int i = 0; i < ListNumber.Count; i++)
            {
                Min += ListNumber[i];
            }

            Console.WriteLine(Min+" "+Max); 
        }
    }
}
