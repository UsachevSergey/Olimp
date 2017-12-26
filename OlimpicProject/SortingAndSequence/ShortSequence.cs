using System; 
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class ShortSequence
    {
        public static void X()
        {
             
            int Number = int.Parse(Console.ReadLine());
            string MASK = "";
            string DOP = "";
            int addint = 1;
            //пока длина строки не достигнет нужного
            while (MASK.Count()<33000)
            {
                DOP += addint;
                addint++;
                MASK += DOP;
            }
            Console.WriteLine(MASK[Number-1].ToString());
        }
    }
}
