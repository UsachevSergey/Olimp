using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 

namespace OlimpicProject.RecursionOverkill
{
    class Permutation
    {
         static List<string> Result = new List<string>();
        public static void X()
        {

            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string s = sr.ReadLine().Trim();
            List<string> ArrayS = new List<string>();
            for (int i = 0; i < s.Count(); i++)
            {
                ArrayS.Add(s[i].ToString());
            }
            for (int i = 0; i < s.Count(); i++)
            {
                List<string> nl = new List<string>(ArrayS);
                nl.RemoveAt(i);
                Perm(nl, ArrayS[i]);
            }
            Result = Result.Distinct().ToList();
            foreach (var item in Result)
            {
                sw.WriteLine(item);
            }
            sw.Close();

        }
        public static void Perm(List<string> L,string S)
        {
            if (L.Count==0)
            {
                Result.Add(S);
            }
            else
            {
                for (int i = 0; i < L.Count; i++)
                {
                    List<string> nl = new List<string>(L); 
                    nl.RemoveAt(i);
                    Perm(nl,S+L[i]);
                }
            }
        }
    }
}
