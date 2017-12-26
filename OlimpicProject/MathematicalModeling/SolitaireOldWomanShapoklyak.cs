using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class SolitaireOldWomanShapoklyak
    {
        public static void X()
        {
            string[] SS = Console.ReadLine().Split(' ');
            int CountCartInOne = Convert.ToInt32(SS[0]);
            int CountCartInTwo = Convert.ToInt32(SS[1]);
            int CountDeck = CountCartInTwo - CountCartInOne + 1;
            int[] arr_card = new int[CountDeck];
            for (int i = 0; i < CountDeck; i++)
            {
                arr_card[i] = CountCartInOne;
                CountCartInOne++;
            } 
            //количество неразобраных карт
            int StillPlaying = CountDeck; 

            int result = 0;
            //пока есть неразобраные карыт
            while (StillPlaying > 0)
            {
                //обнуляем количество нерабраных
                StillPlaying = 0;
                //пройти по всем колодам
                for (int i = 0; i < CountDeck; i++)
                {
                    //если в колоде не 2 карты
                    if (arr_card[i] != 2)
                    { 
                        //если количество карт в колоде делится на 2(четное)
                        if (arr_card[i] % 2 == 0)
                        {
                            //забираем половину
                            arr_card[i] = arr_card[i] / 2;
                            //добавляем количество ходов
                            StillPlaying++;
                        }
                        else
                        {
                            //если нечетное уножаем на 3 и добавляем количество ходов
                            arr_card[i] = (arr_card[i] * 3) + 1;
                            StillPlaying++;
                        }
                    }
                }//for
                result += StillPlaying;
            }
            //выводить количество ходов.Пасьянс всегда сходдится
            Console.WriteLine(result);

        }
    }
}
