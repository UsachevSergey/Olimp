using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OlimpicProject.GraphTheory
{
    class JavaChallenge
    {
        public static void X()
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");

            int CountWindows = int.Parse(sr.ReadLine());

            //главный список
            List<WinApp> Main = new List<WinApp>();

            List<List<Application>> ListApplication = new List<List<Application>>();

            for (int i = 0; i < CountWindows; i++)
            {
                string[] s = sr.ReadLine().Split();
                int app = int.Parse(s[0]);
                int win = int.Parse(s[1]);
                //главный список
                Main.Add(new WinApp() { app = app, win = win });

                //добавляем в список приложение если его нету
                while (ListApplication.Count < app + 1)
                {
                    ListApplication.Add(new List<Application>());
                }
                ListApplication[app].Add(new Application()
                {
                    SerialNumber = win,
                    MinimalPosition = Math.Min(CountWindows - i, i)
                });

            }

            //сортируем окна приложений в порядке их появления в главном списке
            for (int i = 0; i < ListApplication.Count; i++)
            {
                ListApplication[i] = ListApplication[i].OrderBy(x => x.MinimalPosition).ToList();
            }
            //РАЗГРАНИЧИТЬ ЕСЛИ КОЛИЧЕСТВО ПРИЛОЖЕНИЙ МЕНЬШЕ ЧЕМ КОЛИЧЕСТВО ОКОН



            //проходим по главному списку и смотрим как быстрей добраться до очередного 
            for (int i = 0; i < Main.Count; i++)
            {
                if (i == 25000)
                {
                    int s = 25000;
                }
                //минимальное значение для вывода на экран
                int MinimumInMainList = 0;
                //сравниваем как ближе от начала списка или с конца (по главному списку)
                //в дальнейщем использовать как ограничение цикла
                MinimumInMainList = Math.Min(i, Main.Count - i);


                //идем по списку окон внутри приложения и смотрим до какого ближе добратся
                //из внешнего списка + внутрений 
                for (int ai = 0; ai < ListApplication[Main[i].app].Count; ai++)
                {
                    //если путь до текущего занимает больше чем путь по главному списку то прервать
                    if (ListApplication[Main[i].app][ai].MinimalPosition >= MinimumInMainList)
                    {
                        break;
                    }

                    //разница между тем окном в которое надо попасть и тем которое откроется при переходе на текущее приложение
                    int R = 0;
                    if (ListApplication[Main[i].app][ai].SerialNumber > Main[i].win)
                    {

                        R = Math.Min(
                            Main[i].win + (ListApplication[Main[i].app].Count - ListApplication[Main[i].app][ai].SerialNumber),
                            ListApplication[Main[i].app][ai].SerialNumber - Main[i].win
                            );
                    }
                    else
                    {
                        R = Math.Min(
                            ListApplication[Main[i].app][ai].SerialNumber + (ListApplication[Main[i].app].Count - Main[i].win),
                            Main[i].win - ListApplication[Main[i].app][ai].SerialNumber
                            );
                    }
                    //текущий минимум для даного окна
                    int MinimumInSubListAndPathToMain = ListApplication[Main[i].app][ai].MinimalPosition + R;


                    if (MinimumInSubListAndPathToMain < MinimumInMainList)
                    {
                        MinimumInMainList = MinimumInSubListAndPathToMain;
                    }
                }
                sw.Write(MinimumInMainList + " ");
            }


            sr.Close(); sw.Close();
        }


        struct Application
        {
            //минимальная позиция от нуля 
            public int MinimalPosition;
            // порядковый в внутри списка
            public int SerialNumber;
        }
        struct WinApp
        {
            public int app, win;
        }
    }
}
