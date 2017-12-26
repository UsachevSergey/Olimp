using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class JivoiJournal
    {
        public static void X()
        {

            int CountFriends = int.Parse(Console.ReadLine());
            List<string> Friend = new List<string>(); 
            List<string> MutFriends = new List<string>();  

            string FRIENDOUT = "Friends:";
            string MUTOUT = "Mutual Friends:";
            string ALSOOUT = "Also Friend of:";


            for (int i = 0; i < CountFriends; i++)
            {
                string CurrentFriend = Console.ReadLine();
                Friend.Add(CurrentFriend); 
            }
            SortCompareASCIIForString forsort = new SortCompareASCIIForString();
            Friend.Sort(forsort);

            foreach (var item in Friend)
            { 
                FRIENDOUT += " " + item + ",";
            }




            int CountAlsoFriends = int.Parse(Console.ReadLine());
            


            for (int i = 0; i < CountAlsoFriends; i++)
            { 
                string CurrentFriend = Console.ReadLine();
                MutFriends.Add(CurrentFriend); 
            }
            MutFriends.Sort(forsort); 
            foreach (var CurrentFriend in MutFriends)
            {
                if (Friend.Contains(CurrentFriend))
                {
                    MUTOUT += " " + CurrentFriend + ",";
                }
                else
                {
                    ALSOOUT += " " + CurrentFriend + ",";
                }
            } 
            Console.WriteLine(FRIENDOUT.Trim(','));
            Console.WriteLine(MUTOUT.Trim(','));
            Console.WriteLine(ALSOOUT.Trim(','));
        } 




    }
    
    class SortCompareASCIIForString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            //если строки равны
            if (x==y)
            {
                return 0;
            }
            else
             //проходим посимвольно до минимальной длины слов
             //и на каждом шаге проверяем какой символ меньше среди двух.
                for (int i = 0; i < Math.Min(x.Count(),y.Count()) ; i++)
                {
                    char Xchar = x[i];
                    char Ychar = y[i];
                    if (Xchar>Ychar)
                    {
                        return 1;
                    }else if(Xchar<Ychar){
                        return -1;
                    }
                }
            //еСЛИ ПРИ ЦИКЛЕ НЕ ОПРЕДЕЛИЛОСЬ НАИМЕНЬШЕЕ.Т.Е. ОДНО СЛОВО ЯВЛЯЕТСЯ ЧАСТЬЮ ВТОРОГО
            //ТО ВЫВОДИМ НАИМЕНЬШЕЕ ПО ДЛИНЕ


            if (x.Count() == Math.Min(x.Count(), y.Count())) 
            {
                return -1;
            }
            return 1;
            } 
        }
    
}
