using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class ChessKnight
    {
        public static void X()
        {
            string[,] Board = new string[8,8];
            string abcd = "abcdefgh";
            string stpos = Console.ReadLine();
            int i = int.Parse(stpos[1].ToString())-1;
            int j =  abcd.IndexOf(stpos[0].ToString());
            try
            {
                Board[i + 2, j + 1] = "x";
            }
            catch { }
            try
            {
                Board[i + 2, j - 1] = "x";
            }
            catch { }
            try
            {
                Board[i + 1, j + 2] = "x";
            }
            catch { }
            try
            {
                Board[i + 1, j - 2] = "x";
            }
            catch { }
            try
            {
                Board[i - 2, j + 1] = "x";
            }
            catch { }
            try
            {
                Board[i - 2, j - 1] = "x";
            }
            catch { }
            try
            {
                Board[i - 1, j + 2] = "x";
            }
            catch { }
            try
            {
                Board[i - 1, j - 2] = "x";
            }
            catch { }

            //выводить значение..
            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 8; b++)
                {
                    if (Board[a,b]=="x")
                    {
                        Console.WriteLine(abcd[b].ToString()+""+(a+1));
                    }
                }
            } 
        }
    }
}
