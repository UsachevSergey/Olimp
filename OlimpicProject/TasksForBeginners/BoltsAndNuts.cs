using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class BoltsAndNuts
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');
            int Bolts = int.Parse(s[0]);
            int Boltsproc = int.Parse(s[1]);
            int Boltscost = int.Parse(s[2]);
            int Nuts = int.Parse(s2[0]);
            int Nutsproc = int.Parse(s2[1]);
            int Nutscost = int.Parse(s2[2]);
            //осталось
            int LeftBolt = Bolts * ((100 - Boltsproc));
            int LeftNuts = Nuts * ((100 - Nutsproc));
            LeftBolt /= 100;
            LeftNuts /= 100;
            //минимальный остаток 
            int SetBoltNuts = Math.Min(LeftBolt, LeftNuts);
            int result = Boltscost * (Bolts - SetBoltNuts);
            result += Nutscost * (Nuts - SetBoltNuts);
            Console.WriteLine(result);


        }
    }

}
