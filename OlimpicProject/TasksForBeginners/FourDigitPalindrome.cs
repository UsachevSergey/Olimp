using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class FourDigitPalindrome
    {
        public static void X()
        {
            char[] C = Console.ReadLine().ToCharArray(); 
            if (C[0]==C[3]&&C[2]==C[1])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO")
           ; }
        }
    }
}
