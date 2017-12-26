using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Race
    {
        public static void X()
        {

            string[] inputStr = Console.ReadLine().Split(' ');
            int CountHorse = int.Parse(inputStr[0]);
            int Favorite = int.Parse(inputStr[1]);
            bool[] Best = new bool[CountHorse];
            List<List<int>> Superiority = new List<List<int>>();
            for (int i = 0; i < CountHorse; i++)
            {
                Superiority.Add(new List<int>());
            }
            //наполняем список превосходств
            while (true)
            {
                string currentstring = Console.ReadLine();
                if (currentstring=="0")
                {
                    break;
                }
                else
                {
                    //добавляем в нужную колекцию нужное превосходство
                    Superiority[int.Parse(currentstring.Split(' ')[0])-1].Add(int.Parse(currentstring.Split(' ')[1])-1);
                } 
            }

            Superiority[Favorite - 1] = Superiority[Favorite - 1].Distinct().ToList(); ;
            
            //пока возможно чтото добавлять добавляем в колекцию фаворита всех над кем есть превосходство
            bool end = false;
            while (!end)
            {
                end = true;
                //идем по всем элементам фаворитного коня и добавляем все колекции превосходства которые есть
                for (int i = 0; i < Superiority[Favorite - 1].Count(); i++)
                {
                    int currenthourse = Superiority[Favorite - 1][i];
                    if (Superiority[currenthourse].Count>0)
                    {
                        end = false;
                    }
                    Superiority[Favorite - 1].AddRange(Superiority[currenthourse]); 
                    Superiority[currenthourse] = new List<int>();
                    Superiority[Favorite - 1] = Superiority[Favorite - 1].Distinct().ToList();
                }
            }

            //если количество превосходств  равно количеству лошадей кроме текущей
            if (Superiority[Favorite - 1].Count==CountHorse-1 && !Superiority[Favorite - 1].Contains(Favorite - 1))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

           

        }
    }
}
