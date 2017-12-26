using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class ScoreBoard
    {public static void X()
        {
            string[] S = Console.ReadLine().Split();
            int X = int.Parse(S[0]);
            int Y = int.Parse(S[1]);
            string result = "YES";
            string[,] Scoreboard = new string[X,Y];
            for (int i = 0; i < X; i++)
            {
                string currentrgb = Console.ReadLine();
                for (int j = 0; j < Y; j++)
                {
                    Scoreboard[i, j] = currentrgb[j].ToString();
                }
            }
            for (int i = 0; i < X; i++)
            {
                string[] currentnumbers = Console.ReadLine().Split();
                for (int j = 0; j < Y; j++)
                {
                    switch (currentnumbers[j])
                    {
                        case "0":
                            if (Scoreboard[i, j] == ".")
                            {
                                 
                            }
                            else
                            {
                                result = "NO";
                            }
                            break;
                        case "1":
                            if (Scoreboard[i, j] == "." ||Scoreboard[i,j]=="B")
                            {

                            }
                            else
                            {
                                result = "NO";
                            }
                            break; 
                        case "2":
                            if (Scoreboard[i, j] == "." || Scoreboard[i, j] == "G")
                            {

                            }
                            else
                            {
                                result = "NO";
                            }
                            break;   
                        case "3":
                            if (Scoreboard[i, j] == "." || Scoreboard[i, j] == "B" || Scoreboard[i,j]=="G")
                            {

                            }
                            else
                            {
                                result = "NO";
                            }
                            break; 
                        case "4":
                            if (Scoreboard[i, j] == "." ||   Scoreboard[i, j] == "R")
                            {

                            }
                            else
                            {
                                result = "NO";
                            }
                            break; 
                        case "5":
                            if (Scoreboard[i, j] == "." || Scoreboard[i, j] == "B" || Scoreboard[i, j] == "R")
                            {

                            }
                            else
                            {
                                result = "NO";
                            }
                            break; 
                        case "6":
                            if (Scoreboard[i, j] == "." || Scoreboard[i, j] == "R" || Scoreboard[i, j] == "G")
                            {

                            }
                            else
                            {
                                result = "NO";
                            }
                            break; 
                        case "7":
                            if (Scoreboard[i, j] == "." || Scoreboard[i, j] == "B" || Scoreboard[i, j] == "G" || Scoreboard[i, j] == "R")
                            {

                            }
                            else
                            {
                                result = "NO";
                            }
                            break;  
                        default: break;
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
