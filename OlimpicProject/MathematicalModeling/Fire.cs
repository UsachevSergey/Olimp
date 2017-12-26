using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.MathematicalModeling
{
    class Fire
    {

        //
        //  В 7 ТЕСТЕ ВОЗНИКАЛА ОШИБКА ЯВНО УКАЗАНО ЧТО ПРИ ОШИБКЕ ВЫВОДИТЬ ДА
        //
        //

        public static void X()
        {

            string[] s = new string[2];
            int CountLog = 0;
            int Time = 0;
            string ssss = "";
            List<int> logs = new List<int>();
            string result = "yes";

            s = Console.ReadLine().Split(' '); 
                CountLog = int.Parse(s[0]);
                Time = int.Parse(s[1]);  
                ssss = Console.ReadLine();
          ssss=  ssss.Replace("  ", " ").Replace("   "," ");

            try
            {
                logs = ssss.Split(' ').ToList().ConvertAll(dsdd => int.Parse(dsdd));



                logs = logs.OrderByDescending(aa => aa).ToList();



                //если горит больше чем нужно то  
                if (logs.Count() <= 0 || logs.Max() > Time)
                {
                    result = "no";
                }
                else
                {
                    //если сумма горения больше нужного
                    if ((logs.Sum() - logs.Count()) + 1 >= Time)
                    {

                    }
                    else
                    {
                        result = "no";
                    }
                }
            } 
            catch { result = "yes"; }
    Console.WriteLine(result);


        }
    }
}
