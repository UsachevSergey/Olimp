using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GreedyAlgorithm
{
    class Puzzle
    {
        public static void X()
        {
            string[] countstrword = Console.ReadLine().Split();
            int countstr = int.Parse(countstrword[0]);
            int countword = int.Parse(countstrword[1]);
            string MainStr = "";
            //считываем все слова в 1 троку
            for (int i = 0; i < countstr; i++)
            {
                MainStr += Console.ReadLine();
            }

            //получаем слова которые нужно вычиркнуть и вычеркиваем их
            for (int i = 0; i < countword; i++)
            {
                string currentstringdelete = Console.ReadLine();
                for (int q = 0; q < currentstringdelete.Length; q++)
                {
                    string currentletter = currentstringdelete[q].ToString();
                    //ищем первое вхождение этогй буквы в главной строке и вычеркиваем ее
                    int indexdel = MainStr.IndexOf(currentletter);
                    MainStr = MainStr.Substring(0, indexdel) + MainStr.Substring(indexdel + 1);
                } 
            }
            //тут остается только строка которую нужно отсортировать и вывести
            List<char>result = MainStr.OrderBy(a => a.ToString()).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i].ToString());
            }
            Console.WriteLine();

        }
    }
}
