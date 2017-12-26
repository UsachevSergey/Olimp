using System; 
using System.Linq; 

namespace OlimpicProject.GreedyAlgorithm
{
    class BrakeMechanism
    {
        public static void X()
        {
            string s1 = Console.ReadLine().Trim();
            string s2 = Console.ReadLine().Trim(); 
            int[] arrayUP = new int[s1.Length + s2.Length + s2.Length];
            int[] arrT =new int[s2.Length];
            //переводим первый в масив
            for (int i = 0; i < s2.Count(); i++)
            {
                arrT[i] = int.Parse(s2[i].ToString());
            }
            //переводим второй в масив
            for (int i = s2.Length; i < s2.Length+s1.Length; i++)
            {
                arrayUP[i] = int.Parse(s1[i - s2.Length].ToString());
            }
            int MinLenght = 999999;
            for (int i = 0; i < s1.Length+s2.Length+1; i++)
            {
                if (i == s2.Length+1)
                {
                    int stop = 1;
                } 
                bool yes = true;
                for (int j = 0; j < s2.Length; j++)
                {
                    if (arrayUP[i+j]+arrT[j]>3)
                    {
                        yes = false;
                        break;
                    } 
                }
                
                if (yes)
                {
                    //минимальное слева
                    //или позиция с которой просматриваем или левая позиция верхней детали
                    int minleft = Math.Min(i, s2.Length);

                    //правая сторона детали или позиция i +длина второй детали
                    //либо правая сторона первой детали

                    int maxright = Math.Max(i + s2.Length, s1.Length + s2.Length);
                    //текущий минимум разность между правой и левой стороной
                    int currentmin = maxright - minleft;
                    if (currentmin < MinLenght)
                    {
                        MinLenght = currentmin;
                    }
                } 
            }
            Console.WriteLine(MinLenght);


        }
    }
}
