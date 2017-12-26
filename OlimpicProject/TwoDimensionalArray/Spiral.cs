using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Spiral
    {
        public static void X()
        {
            int N =int.Parse(Console.ReadLine());
            Sp psiral = new Sp(new int[N, N]); 
            for (int i = 0; i < N*N; i++)
            {
                psiral.Step();
            }
            psiral.print(N); 
        }

        class Sp
        {
            int[,] Matrix;
            string Route = "R";
            public Sp(int[,] matrix)
            {
                Matrix = matrix;
            }
            int lastX = 0;
            int lastY = -1;
            int LastNumber = 1;

            public void Step()
            {
                try
                {
                    switch (Route)
                    {
                        case "R":
                            if (Matrix[lastX, lastY + 1] == 0)
                            {
                                Matrix[lastX, lastY + 1] = LastNumber;
                                LastNumber++;
                                lastY++;
                            }
                            else { int a = int.Parse("dsdsd"); }
                            break;

                        case "D":
                            if (Matrix[lastX + 1, lastY] == 0)
                            {
                                Matrix[lastX + 1, lastY] = LastNumber;
                                LastNumber++;
                                lastX++;
                            }
                            else { int a = int.Parse("dsdsd"); }

                            break;

                        case "L":

                            if (Matrix[lastX, lastY - 1] == 0)
                            {
                                Matrix[lastX, lastY - 1] = LastNumber;
                                LastNumber++;
                                lastY--;
                            }
                            else { int a = int.Parse("dsdsd"); }

                            break;

                        case "U":

                            if (Matrix[lastX - 1, lastY] == 0)
                            {
                                Matrix[lastX - 1, lastY] = LastNumber;
                                LastNumber++;
                                lastX--;
                            }
                            else { int a = int.Parse("dsdsd"); }   

                            break;

                        default:
                            break;
                    }
                }
                catch
                {
                    ChangeRoute();
                }
            }

            public void ChangeRoute() {
                switch (Route)
                {
                    case "R":
                        Route = "D";
                        break;

                    case "D":
                        Route = "L";
                        break;

                    case "L":
                        Route = "U";
                        break;

                    case "U":
                        Route = "R";
                        break;
                    default:   break;
                }
                Step();
            }

            public void print(int intN)
            {
                for (int i = 0; i < intN; i++)
                {
                    string result = "";
                    for (int j = 0; j < intN; j++)
                    {
                        result += Matrix[i, j]+" ";
                    }
                    result.Trim();
                    Console.WriteLine(result);
                }
            }

        }
    }
}
