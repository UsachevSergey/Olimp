using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Bug
    {
        public static void X()
        {
            string[] Size = Console.ReadLine().Split();
            int countstr = int.Parse(Size[0]);
            int countcol = int.Parse(Size[1]);
            int[,] Matrix = new int[countstr, countcol];
            for (int i = 0; i < countstr; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < countcol; j++)
                {

                    Matrix[i, j] = (s[j].ToString() == "@" ? 999999 : 0);
                }
            }
             
            //ВОЛНА
            List<int> coordX = new List<int>() { 1 };
            List<int> coordY = new List<int>() { 1 };
            while (coordX.Count>0)
            {
                int curi = coordX[0]; 
                int curj = coordY[0];
                coordX.RemoveAt(0);
                coordY.RemoveAt(0);
                try
                {
                    if (Matrix[curi + 1, curj] == 0)
                    {
                        Matrix[curi + 1, curj] = 1;
                        coordX.Add(curi + 1);
                        coordY.Add(curj);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[curi - 1, curj] == 0)
                    {
                        Matrix[curi - 1, curj] = 1;
                        coordX.Add(curi - 1);
                        coordY.Add(curj);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[curi , curj-1] == 0)
                    {
                        Matrix[curi, curj-1] = 1;
                        coordY.Add(curj-1);
                        coordX.Add(curi);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[curi, curj+1] == 0)
                    {
                        Matrix[curi, curj+1] = 1;
                        coordY.Add(curj+1);
                        coordX.Add(curi);
                    }
                }
                catch { }
            }

            

            if (Matrix[countstr - 2, countcol - 2] == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 0; i < countstr; i++)
                {
                    for (int j = 0; j < countcol; j++)
                    {
                        if (Matrix[i, j] == 1)
                        {
                            Matrix[i, j] = 0;
                        }
                    }
                }

                Matrix[1, 1] = 0;
                int currentI = 1;
                int currentJ = 1;
                int Result = 0;
                string CurrentRoute = "D";
                //пока жук не пришел делаем
                while (Matrix[countstr - 2, countcol - 2] != 1)
                {
                    Matrix[currentI, currentJ]++;
                    int up = 999999;
                    int down = 999999;
                    int left = 999999;
                    int right = 999999;

                    try
                    { up = Matrix[currentI - 1, currentJ]; }
                    catch { }
                    try
                    { down = Matrix[currentI + 1, currentJ]; }
                    catch { }
                    try
                    { left = Matrix[currentI, currentJ - 1]; }
                    catch { }
                    try
                    { right = Matrix[currentI, currentJ + 1]; }
                    catch { }

                    int currentMin = Math.Min(Math.Min(Math.Min(down, right), left), up);
                    //проверка на неизменость направления
                    if (CurrentRoute == "D" && down == currentMin)
                    { currentI++; }
                    else if (CurrentRoute == "U" && up == currentMin)
                    { currentI--; }
                    else if (CurrentRoute == "L" && left == currentMin)
                    { currentJ--; }
                    else if (CurrentRoute == "R" && right == currentMin)
                    { currentJ++; }
                    else if (down == currentMin)
                    { currentI++; CurrentRoute = "D"; }
                    else if (right == currentMin)
                    { currentJ++; CurrentRoute = "R"; }
                    else if (up == currentMin)
                    { currentI--; CurrentRoute = "U"; }
                    else if (left == currentMin)
                    { currentJ--; CurrentRoute = "L"; }
                    Result++;
                }
                Console.WriteLine(Result - 1);
            }


        }
    }
}
