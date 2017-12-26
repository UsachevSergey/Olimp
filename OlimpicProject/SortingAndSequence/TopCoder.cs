using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class TopCoder
    {
        public static void X()
        {
            int countCom = int.Parse(Console.ReadLine());
            List<Person> LP = new List<Person>();
            for (int i = 0; i < countCom; i++)
            {
                int countPerson = int.Parse(Console.ReadLine());
                for (int j = 0; j < countPerson; j++)
                {
                    string[] curentperson = Console.ReadLine().Split(' ');
                    Person p = new Person();
                    p.mark =double.Parse(curentperson[0].Replace('.',','));
                    p.name = curentperson[1];
                    LP.Add(p);
                }
            }
           LP = LP.OrderBy(d => d.mark).ToList();
            Console.WriteLine(LP.Count);
            for (int i = LP.Count - 1; i >= 0; i--)
            {   
                string curentmark = LP[i].mark.ToString();
                if (!curentmark.Contains(","))
                {
                    curentmark += ",00";
                }
                else if (curentmark.Split(',')[1].Length==1)
                {
                    curentmark += "0";
                }
               curentmark= curentmark.Replace(',', '.');
                Console.WriteLine(curentmark + " " + LP[i].name);
            }

        } 
    }
    class Person
    {
        public  double mark;
        public string name; 
    }
}
