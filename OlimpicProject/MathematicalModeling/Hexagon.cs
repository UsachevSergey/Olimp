using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Hexagon
    {
        public static void X()
        {
            //количество переходов
            int CountStep = int.Parse(Console.ReadLine());
            //движение по координатам
            int CoordinateX = 0;
            int CoordinateY = 0; 
            //идем по всем шагам
            for (int i = 0; i < CountStep; i++)
            {

                string CurrentCommand = "";
                string CurrentCoordinates = "";
                int CurrentStep = 0;
                CurrentCommand = Console.ReadLine();
                CurrentCoordinates = CurrentCommand.Split(' ')[0];
                CurrentStep = int.Parse(CurrentCommand.Split(' ')[1]);

                switch (CurrentCoordinates)
                {
                    case "X":
                        CoordinateX += CurrentStep;
                        break;
                    case "Y":
                        CoordinateY += CurrentStep;
                        break;
                    case "Z":
                        CoordinateY += CurrentStep;
                        CoordinateX -= CurrentStep;
                        break;
                    default:  break;
                }
            }
            int resultStep = 0;
            //пока одна из координат не в нуле смещатся в 0
            while (CoordinateX != 0 || CoordinateY != 0)
            {
                //если по x 0 то результат равен Y
                if (CoordinateX == 0)
                {
                    resultStep += Math.Abs(CoordinateY);
                    CoordinateY = 0;
                }
                else if (CoordinateY == 0)
                {
                    resultStep += Math.Abs(CoordinateX);
                    CoordinateX = 0;
                }
                else if (CoordinateX > 0 && CoordinateY > 0)
                {//координаты в первом секторе и нужно двигатся до ближайшей оси
                    if (CoordinateX > CoordinateY)
                    {
                        CoordinateY--;
                        resultStep++;
                    }
                    else
                    {
                        CoordinateX--;
                        resultStep++;
                    }
                }
                else if (CoordinateX<0 && CoordinateY<0)
                {
                    if (CoordinateX<CoordinateY)
                    {
                        CoordinateY++;
                        resultStep++;
                    }
                    else
                    {
                        CoordinateX++;
                        resultStep++;
                    }
                }
                else if (CoordinateX<0 && CoordinateY>0)
                {
                    CoordinateX++;
                    CoordinateY--;
                    resultStep++;
                }
                else
                {
                    CoordinateX--;
                    CoordinateY++;
                    resultStep++;
                }  
            }
            Console.WriteLine(resultStep);

        }
    }
}
