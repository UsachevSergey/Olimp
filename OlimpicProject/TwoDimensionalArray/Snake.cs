using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Snake
    {
        public static void X()
        {
            int CountStep = int.Parse(Console.ReadLine());
            SN s = new SN(CountStep);
            for (int i = 0; i < CountStep*CountStep-1; i++)
            {
                s.Step();
            }
            s.Print();
        }


        public class SN
        {
            int[,] Matrix;

            public SN(int CountStep)
            {
                Matrix = new int[CountStep, CountStep]; ;
                Matrix[0, 0] = 1;
                NeadToTheStep = CountStep;
            }
            int NeadToTheStep;
            int StepsTaken = 2;
            int currentCoordinateX = 0;
            int currentCoordinateY = 0;
            string Route = "D";

            public void Step()
            {
                //если движется вверх то занимаем клетку по диагонали вправо вверх иначе  влево вниз
                //при исключение меняем направление движения
                try
                {
                    if (Route == "U")
                    {
                        Matrix[currentCoordinateX - 1, currentCoordinateY + 1] = StepsTaken;
                        currentCoordinateX--;
                        currentCoordinateY++;
                        StepsTaken++;
                    }
                    else
                    {
                        Matrix[currentCoordinateX + 1, currentCoordinateY - 1] = StepsTaken;
                        currentCoordinateX++;
                        currentCoordinateY--;
                        StepsTaken++;
                    }
                }
                catch { changeRoute(); }
            }

            private void changeRoute()
            {
                switch (Route)
                {
                    case "U":
                        //если  зашел за границу свеху
                        if (currentCoordinateX==0 &&currentCoordinateY+1< NeadToTheStep)
                        {
                            currentCoordinateX--;
                            currentCoordinateY++;
                            currentCoordinateY++;
                        }
                        //если зашел справа
                        else
                        {
                            currentCoordinateY++;
                        } 
                        Route = "D";
                        break;
                    case "D":
                        //если  зашел за границу слева
                        if (currentCoordinateX+1 < NeadToTheStep && currentCoordinateY ==0)
                        {
                            currentCoordinateX++;
                            currentCoordinateX++;
                            currentCoordinateY--;
                        }
                        //если зашел по диагонали
                        else
                        {
                            currentCoordinateX++;
                        }

                        Route = "U";
                        break;
                    default:  break;
                }
                Step();
            }
            public void Print()
            {
                for (int i = 0; i < NeadToTheStep ; i++)
                {
                    string res = "";
                    for (int j = 0; j < NeadToTheStep; j++)
                    {
                        res += Matrix[i, j] + " ";
                    }
                    res.Trim();
                    Console.WriteLine(res);
                }
            }
        }//endclass
    }
}
