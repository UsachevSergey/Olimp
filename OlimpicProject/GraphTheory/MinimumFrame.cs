using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class MinimumFrame
    {
        public static void X()
        {

            string[] CountEdgeTop = Console.ReadLine().Split(' ');
            int Size = int.Parse(CountEdgeTop[0]);
            int CountEDGE = int.Parse(CountEdgeTop[1]);

            int[,] Matrix = new int[Size, Size];

            //бесконечность для обозначения отсутствия пути
            int infinity = 9999999;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Matrix[i, j] = infinity;
                }
            }


            int CurrentMinCost = 50000;
            int CurrentStart= 50000;
            int CurrentEnd = 50000;

            //Считываем все ребра
            for (int i = 0; i < CountEDGE; i++)
            { 
                string[] CurrentSTR = Console.ReadLine().Split(' ');
                int Start = int.Parse(CurrentSTR[0])-1;
                int End = int.Parse(CurrentSTR[1])-1;
                int Cost = int.Parse(CurrentSTR[2]);
                //указываем ребра которые взять в первую очередь
                if (Cost<CurrentMinCost)
                {
                    CurrentMinCost = Cost;
                    CurrentStart = Start;
                    CurrentEnd = End;
                }
                Matrix[Start, End] = Cost;
                Matrix[End, Start] = Cost; 
            }
            List<int> CheckedRow = new List<int>();
            //указываем что эти 2 строки уже проверены
            CheckedRow.Add(CurrentStart);
            CheckedRow.Add(CurrentEnd);
            //и заполняем эти строки максимально большими значениями
            for (int i = 0; i < Size; i++)
            {
                Matrix[CurrentStart, i] = infinity;
                Matrix[CurrentEnd, i] = infinity;
            }
            //в результатирующую добавляем стоимость первого минимального ребра
            int ResultMinCost = CurrentMinCost;

            //пока количество провереных строк меньше размера матрицы
            while (CheckedRow.Count<Size)
            {
                CurrentStart = infinity;
                CurrentEnd = infinity;
                CurrentMinCost = infinity; 
                //проходим по провереным столбцам и смотрим какой из весов самый маленький
                for (int i = 0; i < CheckedRow.Count; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        //если в очередном столбце вес меньше текущего минимального то записываем
                        if (Matrix[j,CheckedRow[i]]<CurrentMinCost)
                        {
                            CurrentMinCost = Matrix[j, CheckedRow[i]];
                            CurrentStart = j;
                            CurrentEnd =  CheckedRow[i];
                        } 
                    } 
                }
                //тут должный найти минимальное из тех что ещё не присоеденены 
                //проставляем в выбраных строках значение бесконечности
                for (int i = 0; i < Size; i++)
                {
                    Matrix[CurrentStart, i] = infinity;
                    Matrix[CurrentEnd, i] = infinity;  
                }

                //добавляем в список просмотреных строк вершину которой ещё нету
                if (CheckedRow.Contains(CurrentStart))
                {  CheckedRow.Add(CurrentEnd);}
                else
                { CheckedRow.Add(CurrentStart);} 
                ResultMinCost += CurrentMinCost; 
            }
            if (Size==1)
            {
                ResultMinCost = 0;
            }
            Console.WriteLine(ResultMinCost);
             
        }
    }
}
