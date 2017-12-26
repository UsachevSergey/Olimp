using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Bus2
    {
        public static void X()
        {
            int result = 0;
            string[] s = Console.ReadLine().Split(' ');
            
            int child = int.Parse(s[0]);
            int adult = int.Parse(s[1]);
            int maxinbus = int.Parse(s[2]);

            //минимально автобусов для детей
            if (maxinbus < 3)
            {
                Console.WriteLine(0);
            }
            else
            {
                int minbus = child / (maxinbus - 2);
                if (child % (maxinbus - 2) != 0)
                {
                    minbus++;
                }
                //проверяем хватит ли взрослых 
                if (adult >= minbus * 2)
                {//если взрослых больше или равно минимальному количеству для сопровождения то 

                    result = (child + adult) / maxinbus;
                    if ((child + adult) % maxinbus!=0)
                    {
                        result++;
                    }
                }
                else
                {
                    result = 0;
                }
                Console.WriteLine(result);
            }
        }
    }
}
