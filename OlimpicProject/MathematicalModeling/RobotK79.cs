using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class RobotK79
    {
        public static void X()
        {
            string S = Console.ReadLine();
            Robot r = new Robot();
            bool exe =true;
            for (int i = 0; i < S.Count(); i++)
            {
                //если возвращает true то заканчиваем
                if (r.ACTION(S[i].ToString()))
                {
                    exe = false;
                    break;
                } 
            }
            if (exe)
            {
                Console.WriteLine(-1);
            }

        }
    }
    class Robot
    {
        internal struct position
        {
            
           public int X, Y;

            public position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        public Robot()
        {
            ListPosition.Add(new position(0, 0));
        }
        List<position> ListPosition = new List<position>();
        public int currentX = 0;
        public int currenY = 0;
        int CountStep = 0;
        string CurrentRoute = "UP"; 
        public bool ACTION(string S)
        { 
            //поворот на лево то 
            if (S=="L")
            {
                TurnLeft();
                return false;
            }
            else if (S == "R")
            {
                TurnRight();
                return false;
            }
            else
            {
                Step(); 
              return CheckPosition(); 
            } 
        }

        private void LeaveAMark(position p)
        {
            ListPosition.Add(p);
        }

        private bool CheckPosition()
        {
            position p = new position(currentX, currenY);

            if (ListPosition.Contains(p))
            {
                Console.WriteLine(CountStep);
                return true;
            }
            else
            {
                 LeaveAMark(p);
                return false;

            }
        }

        private void Step()
        {
            switch (CurrentRoute)
            {
                case "UP": currentX--; break;
                case "LEFT": currenY++; break;
                case "DOWN": currentX++; break;
                case "RIGHT": currenY--; break;
                default: break;
            }
            CountStep++;
        }

        private void TurnLeft()
        {
            switch (CurrentRoute)
            {
                case "UP": CurrentRoute = "LEFT"; break;
                case "LEFT": CurrentRoute = "DOWN"; break;
                case "DOWN": CurrentRoute = "RIGHT"; break;
                case "RIGHT": CurrentRoute = "UP"; break;
                default: break;
            }
        }
        private void TurnRight()
        {
            switch (CurrentRoute)
            {
                case "UP": CurrentRoute = "RIGHT"; break;
                case "LEFT": CurrentRoute = "UP"; break;
                case "DOWN": CurrentRoute = "LEFT"; break;
                case "RIGHT": CurrentRoute = "DOWN"; break;
                default: break;
            }
        }
    }

     
}
