using System;
namespace OlimpicProject.ParsingString
{
    class NumberBus
    {
        public static void X()
        {
            int CountBus = int.Parse(Console.ReadLine());

            string pattern = "?ABCEHKMOPTYX";
            int fortryparse = 0;


            for (int i = 0; i < CountBus; i++)
            {
                string NumbBus = Console.ReadLine();
                if (NumbBus.Length == 6 &&
                  pattern.IndexOf(NumbBus.Substring(0, 1)) > 0 &&
                  pattern.IndexOf(NumbBus.Substring(4, 1)) > 0 &&
                  pattern.IndexOf(NumbBus.Substring(5, 1)) > 0 &&
                int.TryParse((NumbBus.Substring(1, 3)), out fortryparse)
                    )
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
        }
    }
}
