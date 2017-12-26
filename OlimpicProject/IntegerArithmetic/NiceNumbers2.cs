using System; 

namespace OlimpicProject.IntegerArithmetic
{
    class NiceNumbers2
    {
        public static void X()
        { 
                int N = int.Parse(Console.ReadLine());
                int resultcount = 1;
                int R = 1; 
                //от 0 до нужного числа 
                for (R = 1; resultcount <= N;R++)
                { 
                    string currentNumber = R.ToString(); 
                    int a = 0;
                int R2 = R;
                int countNumber = R.ToString().Length;
                    for (int i = 0; i < countNumber; i++)
                    {
                    a += R2%10;
                    R2/=10;

                    }
                    if (a % countNumber == 0)
                    {
                        resultcount++; 
                    } 
                }
                Console.WriteLine(R - 1); 
        }
    }
}
