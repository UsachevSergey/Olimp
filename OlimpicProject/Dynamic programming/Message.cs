using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Message
    {
        internal static void X()
        {
            string input = Console.ReadLine();
            string[] result = new string[input.Length];
            result[0] = "1";  
            for (int i = 1; i < input.Length; i++)
            {
                char currentchar = input[i];
                result[i] = "";
                try
                {
                    // если предыдущие 2 буквы могли оказатся одной
                    if (int.Parse(input.Substring(i-1,2))<34 &&input[i-1]!='0')
                    {
                        string add = "0";
                        try
                        {
                            add = result[i - 2];
                        }
                        catch { add="1"; }


                        List<char> listA = add.ToCharArray().ToList();listA.Reverse();
                        List<char> ListB = result[i].ToCharArray().ToList();ListB.Reverse();
                         
                        int carry = 0;
                        for (int j = 0; j < Math.Max(listA.Count,ListB.Count); j++)
                        {
                            if (listA.Count==j)
                            {
                                listA.Add('0');
                            }
                            int a = int.Parse(listA[j].ToString());
                            int b = ListB.Count > j ? int.Parse(ListB[j].ToString()) : 0;
                            carry = carry + a + b;

                            listA[j] =  (carry % 10).ToString().ToCharArray()[0];
                            carry = carry / 10;
                        }
                        if (carry==1)
                        {
                            listA.Add('1');
                        }
                        add = "";
                        for (int h = listA.Count - 1; h >= 0; h--)
                        {
                            add += listA[h].ToString();
                        } 
                        result[i] = add; 
                    }
                }  catch { }


                List<char> ListA2 = result[i - 1].ToCharArray().ToList();ListA2.Reverse();
                List<char> ListB2= result[i].ToCharArray().ToList();ListB2.Reverse();
                int carry2 = 0;
                for (int e = 0; e < Math.Max(ListA2.Count,ListB2.Count); e++)
                {
                    if (ListA2.Count==e)
                    {
                        ListA2.Add('0');
                    }
                    int a = int.Parse(ListA2[e].ToString());
                    int b = ListB2.Count>e?int.Parse(ListB2[e].ToString()):0;
                    carry2 = carry2 + a + b;
                    ListA2[e] = (carry2 % 10).ToString().ToCharArray()[0];
                    carry2 = carry2 / 10;
                }
                if (carry2==1)
                {
                    ListA2.Add('1');
                }

                string add2 = "";
                for (int h = ListA2.Count - 1; h >= 0; h--)
                {
                    add2 += ListA2[h].ToString();
                }
                result[i] = add2;  
            }
             
            if (input.Length>1)
            {
                Console.WriteLine(result[input.Length - 1]);
            }
            else
            {
                Console.WriteLine(1);
            }
             

        }
    }
}
