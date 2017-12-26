using System;

namespace OlimpicProject.Combinatorics
{
    class Inverse
    {
        public static void X()
        {
            short CountNumber = short.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Replace("  ", " ").Trim().Split();
            short[] Nasdasd = new short[CountNumber];
            for (short i = 0; i < CountNumber; i++)
            { 
                short currentposition = short.Parse(s[i]);
                Nasdasd[currentposition - 1] = (short)(i + 1);
            }
            for (int i = 0; i < Nasdasd.Length; i++)
            {
                Console.Write(Nasdasd[i] + " ");
            }
            Console.WriteLine();

        }

    }
}