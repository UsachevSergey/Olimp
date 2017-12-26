using System;
using System.Collections.Generic;
//using System.Linq; 

namespace OlimpicProject.Dynamic_programming
{
    class SMS
    {
        public static void X()
        {
            int CountPress = int.Parse(Console.ReadLine());
            string TextMessage = Console.ReadLine();
            //Переводим в последовательное нажатие цифр
            TextMessage = TextMessage
                 .Replace("A", "2").Replace("B", "22").Replace("C", "2")
                 .Replace("D", "3").Replace("E", "33").Replace("F", "333")
                 .Replace("G", "4").Replace("H", "44").Replace("I", "444")
                 .Replace("J", "5").Replace("K", "55").Replace("L", "555")
                 .Replace("M", "6").Replace("N", "66").Replace("O", "666")
                 .Replace("P", "7").Replace("Q", "77").Replace("R", "777").Replace("S", "7777")
                 .Replace("T", "8").Replace("U", "88").Replace("V", "888")
                 .Replace("W", "9").Replace("X", "99").Replace("Y", "999").Replace("Z", "9999");
            //данные переведены 

            int LenghtMessage = TextMessage.Length;


            //Каждый xxx(каждая кнопка ) будет хранить список из 80 слов (максимум);
            List<string[]> XXX = new List<string[]>();



            //1 имеет только 1 буква
            XXX.Add(new string[81]); XXX[0][0] = "1";
            for (int i = 1; i < 81; i++)
            {
                XXX[0][i] = "0";
            }

            //проходим по всем кнопкам и смотрим какая могла быть когда нажата
            for (int i = 1; i < TextMessage.Length; i++)
            {
                //текущая нажатая кнопка
                string currentbut = TextMessage[i].ToString();


                XXX.Add(new string[81]);

                for (int z = 0; z < 81; z++)
                {
                    XXX[i][z] = "0";
                }

                for (int x = 0; x < (i<81?i:80); x++)
                {
                    if (  XXX[i - 1][x] != "0")
                    {
                        XXX[i][x + 1] = Plus.P(XXX[i - 1][x], XXX[i][x + 1]);
                    }
                }


                //смотрим на первую предыдущую кнопку которая есть точно
                string but_1 = TextMessage[i - 1].ToString();
                //если она похожа и не затронем -1
                if (but_1 == currentbut)
                {
                    if (i > 1)
                    {
                        //добавляем вариант - 2
                        //   Result[i] = Plus.P(Result[i], Result[i - 2]);

                        for (int x = 0; x < (i < 81 ? i : 80); x++)
                        {
                            if ( XXX[i - 2][x] != "0")
                            {
                                XXX[i][x + 1] = Plus.P(XXX[i - 2][x], XXX[i][x + 1]);
                            }

                        }

                        string but_2 = TextMessage[i - 2].ToString();

                        if (but_2 == currentbut)
                        {
                            //тут сравниваем с кнопкой нажатой 2 назад
                            //если она похожа 
                            if (i > 2)
                            {
                                //Result[i] = Plus.P(Result[i], Result[i - 3]);

                                for (int x = 0; x < (i < 81 ? i : 80); x++)
                                {
                                    if ( XXX[i - 3][x] != "0")
                                    {
                                        XXX[i][x + 1] = Plus.P(XXX[i - 3][x], XXX[i][x + 1]);
                                    }
                                }

                                //если кнопка с 4 разными
                                if (currentbut == "9" || currentbut == "7")
                                {
                                    string but_3 = TextMessage[i - 3].ToString();
                                    if (but_3 == currentbut)
                                    {

                                        //тут сравниваем с кнопкой нажатой 3 назад
                                        //если она похожа и не затроним результат -1
                                        if (i > 3)
                                        {
                                            //          Result[i] = Plus.P(Result[i], Result[i - 4]);

                                            for (int x = 0; x < (i < 81 ? i : 80); x++)
                                            {
                                                if (XXX[i - 4][x] != "0")
                                                {
                                                    XXX[i][x + 1] = Plus.P(XXX[i - 4][x], XXX[i][x + 1]);
                                                }

                                            }
                                        } else {
                                            XXX[i][0] = Plus.P(XXX[i][0], "1"); }
                                    }
                                }
                            } else { XXX[i][0] = Plus.P(XXX[i][0], "1"); }
                        }
                    }   else { XXX[i][0] = Plus.P(XXX[i][0], "1"); }
                }


            }//енд фор

            //вывести сколько на последнем шаге есть нужных
            Console.WriteLine(XXX[LenghtMessage-1][CountPress - 1]);
        }

        class Plus
        {
            public static string P(string A, string B)
            {
                if (B == "105833223")
                {
                    int stop = 1;
                }
                int Base = 1000000000;
                List<string> LA = new List<string>();
                List<string> LB = new List<string>();
                //пререводим в листы строк
                for (int i = A.Length; i > 0; i -= 9)
                {
                    if (i < 9)
                    {
                        LA.Add(A.Substring(0, i));
                    }
                    else
                    {
                        LA.Add(A.Substring(i - 9, 9));
                    }
                }
                for (int i = B.Length; i > 0; i -= 9)
                {
                    if (i < 9)
                    {
                        LB.Add(B.Substring(0, i));
                    }
                    else
                    {
                        LB.Add(B.Substring(i - 9, 9));
                    }
                }

                int carry = 0;

                for (int i = 0; i < Math.Max(LA.Count, LB.Count); i++)
                {
                    if (i == LA.Count)
                    {
                        LA.Add("0");
                    }
                    int a = int.Parse(LA[i]);
                    int b = LB.Count > i ? int.Parse(LB[i]) : 0;
                    carry = carry + a + b;
                    LA[i] = (carry % Base).ToString();
                    carry = carry / Base;
                }
                if (carry == 1)
                {
                    LA.Add("1");
                }
                string forreturn = "";
                //добавляем с дописанием до 9 символов
                for (int i = LA.Count - 1; i >= 0; i--)
                {
                    forreturn += LA[i].ToString().PadLeft(9, '0');
                }
                forreturn = forreturn.TrimStart('0');
                return forreturn;



            }
        }
    }
}
