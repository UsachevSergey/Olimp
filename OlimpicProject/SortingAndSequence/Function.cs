using System; 

namespace OlimpicProject.SortingAndSequence
{
    class Function
    {
        public static void X()
        { 
            int Numb = int.Parse(Console.ReadLine());
            Console.WriteLine(Func(Numb));

        }

       static int Func(int numb)
        {
            if (numb ==1)
            {
                return 1;
            }
            else if (numb ==0)
            {
                return 0;
            }
            else
            {
                //если есть остаток
                if (numb%2 ==1)
                {
                    return Func(numb / 2) + Func(numb / 2 + 1);
                }
                else
                {
                    return Func(numb / 2);
                }
                 
            }

        }
    }
}
