using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GraphTheory
{
    class HomeByTrain
    {
        struct Edge
        {
           
            public int start, end; 
            //время прибытия
            public int TimeArive;

            public int TimeStart;
        }
        public static void X()
        {

            string[] CountStationAndEndStation = Console.ReadLine().Split(' ');
            //количество станций
            int CountStation = int.Parse(CountStationAndEndStation[0]);
            //конечная станция
            int EndStation = int.Parse(CountStationAndEndStation[1]);
            //количество поездов
            long CountTrain = long.Parse(Console.ReadLine());
            //список смежности
            List<Edge> Edge = new List<Edge>(); 
            //время прибытия первого поезда
            int FirstTrain = 999999;
            //временые интервалы в которые поезд останавливается на одной из станций
            List<int> TimeInterval = new List<int>();
             

            for (int i = 0; i < CountTrain; i++)
            {
                List<int> CurrentTrain = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
                //количество остановок текущего поезда
                long CountTrainStop = CurrentTrain[0] * 2;
                int laststation = 1; 
                //смотрим направление
                String Route = "";
                if (CurrentTrain[1]> CurrentTrain[3])  { Route = "L";   }
                else   { Route = "R"; }

                //заполняем грани
                for (int k = 1; k < CountTrainStop; k += 2)
                {
                    //заполняем от какой станции к какой двигался и сколько на это потратил время
                    //если первая станция 0 то 
                    if (k == 1)
                    {
                        Edge.Add(new HomeByTrain.Edge()
                        {
                            start = Route == "R" ? 0 : CountStation + 1,
                            end = CurrentTrain[k],
                            TimeArive = CurrentTrain[k + 1],
                            TimeStart = 0
                        });
                        FirstTrain = CurrentTrain[k + 1];
                         TimeInterval.Add(0);
                    }
                    else
                    {
                        Edge.Add(new HomeByTrain.Edge()
                        {
                            start = laststation,
                            end = CurrentTrain[k], 
                            TimeArive = CurrentTrain[k+1],
                             TimeStart = CurrentTrain[k - 1]
                    });
                        //добавляем интервал времени отправлений
                        TimeInterval.Add(CurrentTrain[k - 1]);
                    } 
                    //последний поезд для выставления маршрута
                    laststation = CurrentTrain[k];
                    
                    
                }
            }
            TimeInterval = TimeInterval.Distinct().ToList();
            TimeInterval.Sort();

            //список посещеных станций
            int[] FirstVisit = new int[CountStation + 2];
            for (int i = 0; i < CountStation+2; i++)
            {
                FirstVisit[i] = 2000000000;
            }
            FirstVisit[1] = -1;


            int result = -1;
            //проходим по всем временым интервалам 
            foreach (var item in TimeInterval)
            {
                for (int i = 0; i < Edge.Count; i++)
                {
                    //если время отправления совпадает c текущим
                    if (Edge[i].TimeStart==item)
                    {
                        //и время первого посещения станции меньше текущего
                        if (FirstVisit[Edge[i].start] <= item || Edge[i].start ==-1)
                        {
                            FirstVisit[Edge[i].end] = Math.Min(FirstVisit[Edge[i].end], Edge[i].TimeArive);
                        }
                    }
                }
            }
            if (FirstVisit[EndStation]== 2000000000)
            {
                FirstVisit[EndStation] = -1;
            }
            Console.WriteLine(FirstVisit[EndStation]);



           



        }
    }
}
