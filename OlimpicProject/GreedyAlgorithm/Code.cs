using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GreedyAlgorithm
{
    class Code
    {
        public static void X()
        { 
            string[] s = Console.ReadLine().Split(' ');
            int Summa = int.Parse(s[0]);
            int CountNumber = int.Parse(s[1]);
            string result = "";
            int currentSum = 0;
            while (currentSum<Summa)
            {
                result += (Summa - currentSum) > 9 ? "9" : (Summa - currentSum).ToString();
                currentSum += (Summa - currentSum) > 9 ? 9 : Summa - currentSum;
            }

           result= result.PadRight(CountNumber, '0');
            List<int> CurrentChar = result.Reverse().ToList().ConvertAll(a=>int.Parse(a.ToString()));
            if (CurrentChar[0]==0)
            {
                int indexfirstBZ = CurrentChar.IndexOf(CurrentChar.First(a => a > 0));
                CurrentChar[0]++;
                CurrentChar[indexfirstBZ]--; 
            }
            string result2= "";
            for (int i = 0; i < CurrentChar.Count; i++)
            {
                result2 += CurrentChar[i].ToString();
            }
            Console.WriteLine(result+" "+ result2);

        }
    }
}
