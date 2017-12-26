using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GraphTheory
{
    class ColorsLabyrinth
    {


        public static void X()
        {

            string[] CountRoomAndCorridor = Console.ReadLine().Split(' ');
            int CountRoom = int.Parse(CountRoomAndCorridor[0]);
            int CountCorridor = int.Parse(CountRoomAndCorridor[1]);

            List<List<InfoCorridor>> Edge = new List<List<InfoCorridor>>();
            for (int i = 0; i < CountRoom+1; i++)
            {
                Edge.Add(new List<InfoCorridor>());
            }
            //вносим информацию по коридорам
            for (int i = 0; i < CountCorridor; i++)
            {
                string[] CurrentCorridor = Console.ReadLine().Split(' ');
                 
                //в одну сторону
                Edge[int.Parse(CurrentCorridor[0])].Add(new InfoCorridor()
                { 
                    end = int.Parse(CurrentCorridor[1]),
                    color = int.Parse(CurrentCorridor[2])
                });
                //во вторую сторону
                Edge[int.Parse(CurrentCorridor[1])].Add(new InfoCorridor()
                {
                    end = int.Parse(CurrentCorridor[0]), 
                    color = int.Parse(CurrentCorridor[2])
                });
            }

            int CountManual = int.Parse(Console.ReadLine());
            //получаем инструкцию
            List<int> Manual = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));

            //изначально в 1 комнате
            int CurrentRoom = 1;

            for (int i = 0; i < CountManual; i++)
            {
                //текущая инструкция
                int currentManual = Manual[i];
                //смотрим в какой можно перейти у которых начальная комната текущая и есть коридор с текущим цветом
                //если нет возникнет ошибка
                try
                {
                    CurrentRoom = Edge[CurrentRoom].First(a => a.color == currentManual).end;
                }
                catch { CurrentRoom = -1; break; }
            }
            if (CurrentRoom == -1)
            {
                Console.WriteLine("INCORRECT");
            }
            else
            {
                Console.WriteLine(CurrentRoom);
            }
        } 
        class InfoCorridor
        {
            public int end, color;
        }

    }
}
