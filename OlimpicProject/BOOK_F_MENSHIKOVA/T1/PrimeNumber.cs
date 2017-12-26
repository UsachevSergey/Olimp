using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeNumber
{//НЕ РАБОТАЕТ ТАК
    public static void X()
    {
        
        //считываем
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        List<bool> ArrayNumbers = new List<bool>();
        for (int i = 0; i < 300000; i++) { ArrayNumbers.Add(i % 2 == 0 ? true : false); }
        ArrayNumbers[0] = true;
        ArrayNumbers[1] = true;
        ArrayNumbers[2] = true;
        //показатель того что ничего не выводилось
        bool dontprint = true;
        int IndexFirstPrimeNumbers = 2;
        if (A == 2)
        {
            Console.WriteLine(IndexFirstPrimeNumbers);
            dontprint = false;
        }
        while (IndexFirstPrimeNumbers <= B)
        {
            //получаем индекс первого натурального числа в масиве
            IndexFirstPrimeNumbers = ArrayNumbers.IndexOf(false);
            //если в деапозоне подготовить к печате
            if (IndexFirstPrimeNumbers >= A && IndexFirstPrimeNumbers <= B)
            {
                Console.WriteLine(IndexFirstPrimeNumbers);
                dontprint = false;
            }
            for (int i = IndexFirstPrimeNumbers; i < 300000; i += IndexFirstPrimeNumbers)
            {
                ArrayNumbers[i] = true;
            }
        }
        if (dontprint) { Console.WriteLine("Absent"); }
         
    }
}