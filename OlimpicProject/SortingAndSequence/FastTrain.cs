using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class FastTrain
    {
        public static void X()
        {
            //количество поездов
            int CountTrain = int.Parse(Console.ReadLine());
            string FastNameTrain = ""; 
            Double maxtotal = 999999;
            for (int i = 0; i < CountTrain; i++)
            {
                string currenttrain = Console.ReadLine();

                string name = currenttrain.Split('"')[1];
                string secondstring = currenttrain.Split('"')[2];
                string timestart = secondstring.Split(' ')[1];
                string timefinish = secondstring.Split(' ')[2];
                TimeSpan tstart = new TimeSpan(int.Parse(timestart.Split(':')[0]), int.Parse(timestart.Split(':')[1]), 0);
                TimeSpan tend = new TimeSpan(int.Parse(timefinish.Split(':')[0]), int.Parse(timefinish.Split(':')[1]), 0);
                TimeSpan TTotal = tend - tstart;
                double TotalMinut = TTotal.TotalMinutes;
                if (TotalMinut <= 0)
                {
                    TotalMinut += (24 * 60);
                }
                if (TotalMinut < maxtotal)
                { 
                    maxtotal = TotalMinut;
                    FastNameTrain = name;
                }
            }
                double SpeedInMinutes = 650 / maxtotal;
                double SpeedInHours = SpeedInMinutes * 60;
                SpeedInHours = Math.Round(SpeedInHours);
              
            Console.WriteLine("The fastest train is \"{0}\".", FastNameTrain);
            Console.WriteLine("It's speed is {0} km/h, approximately.", SpeedInHours);
        } 
        }   
    } 
