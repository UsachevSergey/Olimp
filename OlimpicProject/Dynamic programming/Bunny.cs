using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Bunny
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Replace("  "," ").Split();
            int CountStep = int.Parse(s[1]);
            int MaxJump = int.Parse(s[0]);
            string[] result = new string[CountStep+1];
            result[0] = "1"; 
            int NumberBase=1000000000;
            for (int i = 1; i < CountStep+1; i++)
            {
                string currentVar = "0";

                //пройти по вем вариантам с которого может прити и добавить в текущий
                for (int j =  (i- MaxJump > 0?i- MaxJump : 0) ; j < i; j++)
                { 
                    int carry = 0;
                    //первое число
                    List<int> NumberA = new List<int>();
                    List<int> NumberB = new List<int>();
                    //пройти по числу и перевести в масив




                    for (int q = currentVar.Length; q > 0; q -= 9)
                    {
                        if (q < 9)
                        {
                            NumberA.Add(int.Parse(currentVar.Substring(0,q)));
                        }
                        else
                        {

                            NumberA.Add(int.Parse(currentVar.Substring(q - 9, 9)));
                        } 
                    }
                    for (int q = result[j].Length; q >0; q -= 9)
                    { 
                        if (q < 9)
                        {
                            NumberB.Add(int.Parse(result[j].Substring(0, q)));
                        }
                        else
                        {

                            NumberB.Add(int.Parse(result[j].Substring(q - 9, 9)));
                        }
                    }




                    for (int x = 0; x < Math.Max(NumberA.Count,NumberB.Count); x++)
                    {
                        if (NumberA.Count==x)
                        {
                            NumberA.Add(0);
                        }
                        carry = carry + NumberA[x] + (NumberB.Count > x ? NumberB[x] : 0);
                        NumberA[x] = carry % NumberBase;
                        carry = carry / NumberBase; 
                    }
                    if (carry==1)
                    {
                        NumberA.Add(1);
                    }


                    currentVar = "";
                    for (int y = NumberA.Count - 1; y >= 0; y--)
                    {
                        string add = NumberA[y].ToString();
                        while (add.Length != 9)
                        {
                            add = "0" + add;
                        }
                        
                        currentVar += add;
                    }
                   currentVar= currentVar.TrimStart('0');
                }

                result[i] = currentVar;
            }

            Console.WriteLine(result[CountStep]);


        }
    }
}
