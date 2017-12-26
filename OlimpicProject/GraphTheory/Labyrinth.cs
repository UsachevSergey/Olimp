using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Labyrinth
    {
        public static void X()
        {

            string[] HWH = Console.ReadLine().Split(' ');
            int Height = int.Parse(HWH[0]);
            int CountStr =   int.Parse(HWH[1]);
            int CountCol =  int.Parse(HWH[2]);
            int[,,] Matrix3D = new int[Height, CountStr, CountCol];

            int startH = 0, startI = 0, startJ = 0;
            int endH = 0, endI = 0, endJ = 0;


            for (int h = 0; h < Height; h++)
            {
                if (h>0)
                {
                    Console.ReadLine();
                }
                for (int i = 0; i < CountStr; i++)
                { 
                    string currentstr = Console.ReadLine();
                    for (int j = 0; j < CountCol; j++)
                    {
                        if (currentstr[j].ToString() == ".")
                        {
                            Matrix3D[h, i, j] = 0;
                        }
                        else if (currentstr[j].ToString() == "o")
                        {
                            Matrix3D[h, i, j] = 9;
                        }
                        else if (currentstr[j].ToString()=="1")
                        {
                            startH = h;
                            startI = i;
                            startJ = j;
                        }
                        else
                        {
                            endH = h;
                            endI = i;
                            endJ = j;
                        }
                    }
                }
            }
            int CountStep = 0;

            Matrix3D[startH, startI, startJ] = 1;
            List<int> H = new List<int>() { startH};
            List<int> I = new List<int>() { startI};
            List<int> J = new List<int>() { startJ }; 
            List<int> Cost = new List<int>() { 1 };
            //вечно двигаемся пока не появится break
            while (I.Count>0)
            {
                int h = H[0]; H.RemoveAt(0);
                int i = I[0]; I.RemoveAt(0);
                int j = J[0]; J.RemoveAt(0);
                int cost = Cost[0]; Cost.RemoveAt(0);
                //можно двигатся только в 5 направлений лево право верх низ впол
                try
                { //влево
                    if (Matrix3D[h, i, j-1] == 0)
                    {
                        Matrix3D[h, i, j-1] = 1;
                        H.Add(h);
                        I.Add(i);
                        J.Add(j-1);
                        Cost.Add(cost + 1);
                    }
                }
                catch { }
                try
                { //вправо
                    if (Matrix3D[h, i, j+1] == 0)
                    {
                        Matrix3D[h, i, j+1] = 1;
                        H.Add(h);
                        I.Add(i);
                        J.Add(j+1);
                        Cost.Add(cost + 1);
                    }
                }
                catch { }
                try
                {//вниз
                    if (Matrix3D[h, i+1, j] == 0)
                    {
                        Matrix3D[h, i+1, j] = 1;
                        H.Add(h);
                        I.Add(i+1);
                        J.Add(j);
                        Cost.Add(cost + 1);
                    }
                }
                catch { }
                try
                {//вверх
                    if (Matrix3D[h, i-1, j] == 0)
                    {
                        Matrix3D[h, i-1, j] = 1;
                        H.Add(h);
                        I.Add(i-1);
                        J.Add(j);
                        Cost.Add(cost + 1);
                    }
                }
                catch { }
                try
                {//впол
                    if (Matrix3D[h+1, i, j] == 0)
                    {
                        Matrix3D[h+1, i, j] = 1;
                        H.Add(h+1);
                        I.Add(i);
                        J.Add(j);
                        Cost.Add(cost + 1);
                    }
                }
                catch { }

                if (Matrix3D[endH,endI,endJ]==1)
                {
                    CountStep = cost * 5;
                    break;
                } 
            }
            Console.WriteLine(CountStep);



        }
    }
}
