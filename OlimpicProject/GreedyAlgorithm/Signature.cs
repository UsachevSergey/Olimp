using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq; 

namespace OlimpicProject.GreedyAlgorithm
{
    class Signature
    {
        public static void X()
        {
            
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt"); 
            string s1 = sr.ReadLine().Trim();
            if (s1.Length > 1000)
            {
                Console.WriteLine(123);
            }
            string s2 = sr.ReadLine().Trim();
            if (s2.Length>1000)
            {
                Console.WriteLine(123);
            }
            if (s2.Length>s1.Length)
            {  string s3 = s1;  s1 = s2;  s2 = s3; }
            string forres1 = s1;  string forres2 = s2; 
             s1 = s1.ToUpper();  s2 = s2.ToUpper();
  

            char[] main = new char[s2.Length + s1.Length + s2.Length];
            int ii = 0;
            for (int i = s2.Length; i < s1.Length+s2.Length; i++)
            {
               main[i] = s1[ii];
                ii++;
            }
            char[] second = s2.ToCharArray();

            string CurrentResult = s1 + s2;
            //текущие строки результатов
            List<string> CurrentStringResult = new List<string>();

            List<int> LEFTS  = new List<int>();
            List<int> RIGHTS = new List<int>();


            int currentSize = CurrentResult.Length;

            //чтобы каждый раз не пересчитывать
            int Lenght2word = s1.Length + s2.Length+1;
            //идем по главному масиву
            for (int i = 0; i < Lenght2word; i++)
            {
                bool yes = true;
                //идем по второстипеному масиву 

                int minPosition = s2.Length - i;
                if (minPosition<0)
                {
                    minPosition = 0;
                }

                for (int j = minPosition; j < second.Length; j++)
                { 
                    if (main[i+j]!='\0')
                    {
                        if (main[i + j]!= second[j])
                        { yes = false;break; } 
                    }  
                }  
                if (yes)
                { 
                    int left = Math.Min(i, s2.Length);
                    //справа или длина первого +2 слова или i + длина второго слова
                    int right = Math.Max(i + s2.Length, s1.Length + s2.Length);
                    int RightLegt = right - left;
                     
                    if (RightLegt <= currentSize)
                    {
                          if (RightLegt < currentSize)
                        { 
                            LEFTS = new List<int>();
                            RIGHTS = new List<int>(); 
                            currentSize = RightLegt;
                        } 
                        LEFTS.Add(left);
                        RIGHTS.Add(right);
                    }
                }
            } 
                for (int i = 0; i < LEFTS.Count; i++)
            {
                
                //     если первый пробел то добавляем кусок второго слова в начало
                //        иначе добавляем кусок второго слова в конец
                if (main[LEFTS[i]] == '\0')
                {
                    string l1 = s2.Substring(0, s2.Length - LEFTS[i]);
                    string l2 = s1;
                    CurrentStringResult.Add(l1 + l2);
                }
                else
                {
                    string l2 = s1;
                    //общая длина получаемого слова
                    int LEN = RIGHTS[i] - LEFTS[i];
                    //количество букв которые надо дописать
                    LEN = LEN - s1.Length;
                    string l1 = s2.Substring(s2.Length-LEN, RIGHTS[i] - s1.Length - s2.Length);
                    
                    CurrentStringResult.Add(l2 + l1);
                }

            }



            
            //тут список результатов уже есть.
            CurrentStringResult = CurrentStringResult.OrderBy(a=>a).ToList(); 
            //переводим в маленький регистр
            string result = CurrentStringResult[0].ToLower(); 

            
            //если начинается на 1 слово то ищем первое вхождение второго
            int index = 0;

            if (forres1 == forres2)
            {
                sw.WriteLine(forres1);
            }
            else
            {  
                    if (forres1.ToLower() == result.Substring(0, s1.Length))
                    {
                        result = result.Substring(0, 1).ToUpper() + result.Substring(1, result.Count() - 1);
                        index = result.IndexOf(s2.ToLower());
                        if (index == -1)
                        {
                            index = result.IndexOf(forres2);
                        }
                    }
                    else
                    {
                        result = result.Substring(0, 1).ToUpper() + result.Substring(1, result.Count() - 1);
                        index = result.IndexOf(s1.ToLower());
                        if (index == -1)
                        {
                            index = result.IndexOf(forres1);
                        }
                    }
                    result = result.Substring(0, index) + result.Substring(index, 1).ToUpper() + result.Substring(index + 1, result.Length - index - 1);
           
                sw.WriteLine(result); 
            }

            sw.Close();


        }
    }
}
