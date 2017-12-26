using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Mockery
    {
        public static void X()
        {

            int CountArea = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[CountArea, CountArea];
            for (int i = 0; i < CountArea; i++)
            {

                string[] CurrentArea = Console.ReadLine().Split(' ');
                for (int j = 0; j < CountArea; j++)
                {
                    Matrix[i, j] = int.Parse(CurrentArea[j]);
                }
            }
            int MinPath = 99999;

            //данные внесены.теперь проверяемы
            for (int i = 0; i < CountArea; i++)
            {
                for (int j = 0; j < CountArea; j++)
                {
                    //исключаем движение назад и 0 путь 
                    if (i != j && Matrix[i, j] != 0)
                    {
                        int currentPathIJ = Matrix[i, j];

                        //пройти по всем элементам зоны j 
                        for (int z = 0; z < CountArea; z++)
                        {
                            //не рассматривать дорогу в i и не расматривать путь назад и нулевой путь
                            if (z != i && z != j && Matrix[j, z] != 0)
                            {
                                int CurrentPathJZ = Matrix[j, z];
                                int CurrentPAthZI = Matrix[z, i];
                                if (MinPath > CurrentPathJZ + CurrentPAthZI + currentPathIJ)
                                {
                                    MinPath = CurrentPathJZ + CurrentPAthZI + currentPathIJ;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(MinPath);


        }
    }
}
