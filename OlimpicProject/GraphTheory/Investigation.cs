using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Investigation
    {
        public static void X()
        { 
            int CountDepartament = int.Parse(Console.ReadLine()); 
            List<int> NumberDepartamentForTraking = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            int DepartamentA = NumberDepartamentForTraking[0];
            int DepartamentB = NumberDepartamentForTraking[1]; 
            List<int> LocalNetwork = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            int[] Shema = new int[CountDepartament + 1];


            //заполняем узлы подключеные
            for (int i = 0; i < CountDepartament-1; i++)
            {
                Shema[i + 2] = LocalNetwork[i];
            }
            //поднимаемся по узлам

            //количество отделов по умолчанию все 0.
            int[] Arrayresult = new int[CountDepartament+1];

            // начинаем заполнять с 1 
            int currentnode = DepartamentA;
            Arrayresult[currentnode] = 1;
            while (currentnode > 1)
            {
                //вытаскиваем верхний уровень и проставляем в таблице 1
                currentnode = Shema[currentnode];
                Arrayresult[currentnode] = 1;
            }

            currentnode = DepartamentB;

            Arrayresult[currentnode]++;
            while (currentnode > 0)
            {
                if (Arrayresult[currentnode]==2)
                {
                    break;
                }
                //вытаскиваем верхний уровень и проставляем в таблице 1
                currentnode = Shema[currentnode];
                Arrayresult[currentnode] += 1;
            }


            Console.WriteLine(currentnode);
             
        }
       
        struct net
        {
            public int up, down;
        }
    }
}
