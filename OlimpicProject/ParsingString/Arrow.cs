using System; 
namespace OlimpicProject.ParsingString
{
    class Arrow
    {
        public static void X()
        {
            string S = Console.ReadLine();
            int result = 0;
            string s = ">>-->";
            string s2 = "<--<<";
            for (int i = 0; i < S.Length-4; i++)
            {
                if (S.Substring(i,5)==s ||
                    S.Substring(i,5)==s2)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
