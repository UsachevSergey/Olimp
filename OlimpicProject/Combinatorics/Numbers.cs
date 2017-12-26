using System;  

namespace OlimpicProject.Combinatorics
{
    class Numbers
    {
        public static void X()
        {
            int CurrentNumber = int.Parse(Console.ReadLine());

            //количество которое делится на 2
            int Dividingto2 = (CurrentNumber) / 2;

            //количество которое делится на 3
            int Dividingto3 = (CurrentNumber) / 3;

            //количество которое делится на 5
            int Dividingto5 = (CurrentNumber ) / 5;

            //количество которое делится на 2 и 3
            int Dividingto2and3 = (CurrentNumber) / 6;

            //количество которое делится на 2 и 5
            int Dividingto2and5 = (CurrentNumber) / 10;

            //количество которое делится на 3 и 5
            int Dividingto3and5 = (CurrentNumber) / 15;

            //количество которое делится на 2 и 3 и 5
            int Dividingto2and3and5 = (CurrentNumber) / 30;

            //вычитаем то что делится и на 2 и на 3 и на 5
            Dividingto2and3 -= Dividingto2and3and5;
            Dividingto2and5 -= Dividingto2and3and5;
            Dividingto3and5 -= Dividingto2and3and5;
            
            //исключаем пересечения
            Dividingto2 -= Dividingto2and3;
            Dividingto2 -= Dividingto2and5;
            Dividingto2 -= Dividingto2and3and5;
            Dividingto3 -= Dividingto2and3;
            Dividingto3 -= Dividingto3and5; 
            Dividingto3 -= Dividingto2and3and5;
            Dividingto5 -= Dividingto2and5;
            Dividingto5 -= Dividingto3and5; 
            Dividingto5 -= Dividingto2and3and5;

            int result = CurrentNumber - Dividingto2 - Dividingto3 - Dividingto5 - Dividingto2and3 - Dividingto2and5 - Dividingto3and5 -Dividingto2and3and5 ;
            Console.WriteLine(result);
        }
    }
}
