using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.Geometry
{
    class Symmetry
    {
        public static void X()
        { 
            List<int> s = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            //s[0] - положение прямой от оси y
            //s[1] - положение прямой от оси x

            //выясняем относительно какой оси паралельно
            bool Horizont = s[0]==s[2]  ? true :false; 
            //координаты точки
             List<int> CoordsX = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            //если прямая горизонтальная то   
            if (Horizont)
            {
                //если прямая выше точки
                if (s[0]>CoordsX[0])
                {
                    //то добавляем разницу между прямой и точкой
                    CoordsX[0] = s[0] + Math.Abs(
                         s[0] -CoordsX[0] );
                }
                else
                {
                    CoordsX[0] = s[0] - Math.Abs(
                       s[0]-CoordsX[0] );
                }
            }
            else
            {
                //если прямая выше точки
                if (s[1] > CoordsX[1])
                {
                    //то добавляем разницу между прямой и точкой
                    CoordsX[1] = s[1] + Math.Abs(
                        s[1]-CoordsX[1]);
                }
                else
                {
                    CoordsX[1] = s[1] - Math.Abs(
                       s[1] - CoordsX[1]);
                }
            }
             
            Console.WriteLine(CoordsX[0]+" "+ CoordsX[1]);


        }
    }
}
