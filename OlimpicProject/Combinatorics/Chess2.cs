using System; 


class Chess2
{
    public static void X()
    {
        
        string[] MN = Console.ReadLine().Split(' ');
        int Size = int.Parse(MN[0]);
        int Size2 = Size;
        int Count = int.Parse(MN[1]);
        int Count2 = Count;
        int result = Count > 0 && Size > 0 ? 1 : 0;
        if (Size >= Count)
        {
            while (Count > 0)
            {
                result *= Size;
                Size--;
                Count--;
            }
            //size в данный момент незаполненое количество ячеек.считаем сколько таких вариантов может быть
            int CountVoid = fact(Size2) / (fact(Count2) * fact(Size2 - Count2));
            result *= CountVoid;

        }
        else
        {
            result = 0;
        }
        Console.WriteLine(result);
    }

    public static int fact(int a)
    {
        int result = 1;
        for (int i = 0; i < a; i++)
        {
            result *= i + 1;
        }
        return result;
    }

}

