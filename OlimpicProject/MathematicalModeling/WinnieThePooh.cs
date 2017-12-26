using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class WinnieThePooh
    {
        public static void X()
        {
            string[] S = Console.ReadLine().Split(' ');
            string[] S2 = Console.ReadLine().Split(' '); 
            WP winny = new WP(int.Parse(S[0]), int.Parse(S[1]), int.Parse(S2[0])-1, int.Parse(S2[1])-1);
            while (winny.Verification())
            {
                winny.TakeStep();
            }
            Console.WriteLine(winny.CountStep);


        }
    }
    class WP
    {
        public int fX, fY;
        public int FinalCoordinateX, FinalCoordinateY;

        public int[,] Field;
        public int CountStep = 0;
        public int CoordinateX = 0;
        public int CoordinateY = -1;

        public string CurrentRoute = "R";

        public WP(int fX, int fY, int finalCoordinateX, int finalCoordinateY)
        {
            this.fX = fX;
            this.fY = fY;
            Field = new int[fX, fY];
            FinalCoordinateX = finalCoordinateX;
            FinalCoordinateY = finalCoordinateY;
        }

        public void TakeStep()
        {
            switch (CurrentRoute)
            {
                case "U":
                    if (CoordinateX > 0 && Field[CoordinateX - 1, CoordinateY] != 1)
                    {
                        Field[CoordinateX - 1, CoordinateY] = 1;
                        CoordinateX--;
                        CountStep++;

                    }
                    else
                    {
                        CurrentRoute = "R";
                        TakeStep();
                    }
                    break;

                case "D":
                    if (CoordinateX < fX - 1 && Field[CoordinateX + 1, CoordinateY] != 1)
                    {
                        Field[CoordinateX + 1, CoordinateY] = 1;
                        CoordinateX++;
                        CountStep++;

                    }
                    else
                    {
                        CurrentRoute = "L";
                        TakeStep();
                    }
                    break;

                case "R":
                    if (CoordinateY < fY - 1 && Field[CoordinateX, CoordinateY + 1] != 1)
                    {
                        Field[CoordinateX, CoordinateY + 1] = 1;
                        CoordinateY++;
                        CountStep++;

                    }
                    else
                    {
                        CurrentRoute = "D";
                        TakeStep();
                    }
                    break;
                case "L":
                    if (CoordinateY > 0 && Field[CoordinateX, CoordinateY - 1] != 1)
                    {
                        Field[CoordinateX, CoordinateY - 1] = 1;
                        CoordinateY--;
                        CountStep++;

                    }
                    else
                    {
                        CurrentRoute = "U";
                        TakeStep();
                    }
                    break;
                default: break;
            }
        }

        public bool Verification()
        {
            if (CoordinateX == FinalCoordinateX && CoordinateY == FinalCoordinateY)
            {
                return false;
            }
            return true;
        }

    }//endclass





}
