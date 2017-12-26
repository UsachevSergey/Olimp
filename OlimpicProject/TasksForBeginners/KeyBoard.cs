using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class KeyBoard
    {
        public static void X()
        {
            string s = "qwertyuiopasdfghjklzxcvbnmq";
            char inp = Console.ReadLine().ToCharArray()[0];
            int index = s.IndexOf(inp);
            Console.WriteLine(s.Substring(index+1,1));
        } 
    }
}
