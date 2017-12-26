using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class ComputerNet
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int CountHouse = int.Parse(s[0]);
            int CostOneMeter = int.Parse(s[1]);
            long MaximumAvailableCost = long.Parse(s[2]);
            List<House> ListHouse = new List<House>();
             
            for (int i = 0; i < CountHouse; i++)
            {
                //получаем список всех домов
                s = Console.ReadLine().Split(' ');
                House h = new House(int.Parse(s[0]), int.Parse(s[1]));
                ListHouse.Add(h);
            }
             
            s = Console.ReadLine().Split(' ');
            House BaseNET = new House(int.Parse(s[0]), int.Parse(s[1]));
            //достаточно денег
            bool Sufficient = false;

            //проходим по всем домам и смотим куда дешевле подключить
            for (int i = 0; i < CountHouse; i++)
            {
                //смотрим расстояние от текущего дома до базовой точки
                double a = Math.Abs(ListHouse[i].X - BaseNET.X);
                double b = Math.Abs(ListHouse[i].Y - BaseNET.Y);
                //вычисляем растояние по пифагору
                double current_cabel = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                //пройти по всем домам от дома к которому подключен интернет и проверить сколько будет стоить подключение
                for (int j = 0; j < CountHouse; j++)
                {
                    double aa = Math.Abs(ListHouse[i].X - ListHouse[j].X);
                    double bb = Math.Abs(ListHouse[i].Y - ListHouse[j].Y);
                    //вычисляем растояние по пифагору
                    double g = Math.Sqrt(Math.Pow(aa, 2) + Math.Pow(bb, 2));
                    //добавляем к текущему кабелю  растояние до теущего дома
                    current_cabel += g;
                }

                //если длина кабеля * стоимость меньше существующих денег то подключение возможно
                if (current_cabel * CostOneMeter <= MaximumAvailableCost)
                {
                    i = CountHouse;
                    Sufficient = true;
                }
            } 
            if (Sufficient)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            } 
        }


        public struct House
        {
             
            public int X, Y;

            public House(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
