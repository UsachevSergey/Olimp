using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class Dictionary_291
    {
        public static void X()
        {
            int CountWord = int.Parse(Console.ReadLine());
            List<List<char>> ListWord = new List<List<char>>();
            for (int i = 0; i < CountWord; i++)
            {
                ListWord.Add(Console.ReadLine().ToCharArray().ToList());
                ListWord[i].Sort();
            }
           List<char> Letter = Console.ReadLine().ToCharArray().ToList();
            Letter.Sort();
            string ForComparison = "";
            for (int i = 0; i < Letter.Count(); i++)
            {
                ForComparison += Letter[i].ToString();
            }

            int Result = 0;

            for (int i = 0; i < CountWord; i++)
            {
                List<char> CurrentWord = ListWord[i];
                bool yes = true;
                int indexMaxletter = 0;
                for (int d = 0; d < CurrentWord.Count; d++)
                {
                    //если такой символ есть то добавляем максимум индекс 
                    if (ForComparison.IndexOf(CurrentWord[d].ToString(),indexMaxletter)>=0)
                    {
                        indexMaxletter = ForComparison.IndexOf(CurrentWord[d].ToString(), indexMaxletter)+1;
                    }
                    else
                    {
                        yes = false; 
                        break;
                    }
                } 
                if (yes)
                {
                    Result++;
                }
            }
            Console.WriteLine(Result);
        }
    }
}
