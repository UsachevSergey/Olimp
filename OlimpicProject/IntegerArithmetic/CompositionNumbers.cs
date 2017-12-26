using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompositionNumbers
{
    public static void X()
    {
        int A = int.Parse(Console.ReadLine());
        req R = new req();
        if (A>9)
        {
            R.Recursion(A, "");
            string result = R.MinNumber();
            Console.WriteLine(result);
        }
        else if(A>0)
        {
            Console.WriteLine(A);
        }
        else
        {
            Console.WriteLine(10);
        }
         
    }
}
class req
{
    string result=""; 
    public void Recursion(int Numb, string currentResult)
    {
        if (Numb == 1)
        { 
                result = currentResult.ToString();
        }
        else
        {
            for (int i = 9; i > 1; i--)
            {//если делится без остатка то передаем дальше
                if (Numb % i == 0)
                {
                    Recursion(Numb / i, currentResult + "" + i);
                    break;
                }
            }
        }
    }
    public string MinNumber()
    {
        if (result!="")
        {
            List<Char> ListR = result.ToCharArray().ToList();
            ListR.Sort();
            string s = "";
            for (int i = 0; i < ListR.Count; i++)
            {
                s += ListR[i].ToString();
            }
            return s;
        }
        else
        {
            return "-1";
        } 
    }

}