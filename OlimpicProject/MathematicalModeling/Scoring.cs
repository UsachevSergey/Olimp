using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Scoring
    {
        public static void X()
        {
            //количество тестов
            int count_test = int.Parse(Console.ReadLine());
            //
            //масив балов
            int[] ArrayScore = new int[count_test];
            //баллыза тесты
            string[] Scores = Console.ReadLine().Split(' ');
            for (int i = 0; i < count_test; i++)
            {
                ArrayScore[i] = int.Parse(Scores[i]);
            }
            //бонусные балы начисляемые при правильном ответе на всё
            int bonus = int.Parse(Console.ReadLine());
            int CountTry = int.Parse(Console.ReadLine());
            int MaxScore = 0;
            //пройти по всем попыткам
            for (int i = 0; i < CountTry; i++)
            {
                //считываем текущие результаты
                string[] current_popitka = Console.ReadLine().Split(' ');

                bool currentbonus = true;
                int current_score = 0;
                //пройти по ответам
                for (int j = 0; j < count_test; j++)
                {
                    //если ответил правильно  то добавляем очки за ответ иначе лишаем бонуса
                    if (current_popitka[j] == "1")
                    {
                        current_score += ArrayScore[j];
                    }
                    else
                    {
                        currentbonus = false;
                    }
                }

                //текущий бонус - текущая попытка *2
                current_score -= i * 2;
                //если ответил всё   верно
                if (currentbonus)
                {
                    current_score += bonus;
                }
                //если текущий результат лучше максимального
                if (current_score > MaxScore)
                {
                    MaxScore = current_score;
                }
                //вывести текущий
                Console.WriteLine(MaxScore);
            }
        }
    }
}