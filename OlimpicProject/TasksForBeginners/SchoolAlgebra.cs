using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class SchoolAlgebra
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            string result = "";
            if (s[0]!="0")
            {
                result += s[0];
            }
            if (s[1]!="0")
            {
                if (!s[1].Contains("-") && s[0]!="0")
                {
                    result += "+";
                }
                if (s[1]=="1")
                {
                    s[1] = "";
                }
                if (s[1]=="-1")
                {
                    s[1] = "-";
                }
                result += s[1] + "x";
            } 
            if (s[2] != "0")
            {
                if (!s[2].Contains("-"))
                {
                    if (s[0]!="0" ||s[1]!="1")
                    {
                        result += "+";
                    }
                }

                if (s[2] == "1")
                {
                    s[2] = "";
                }
                if (s[2] == "-1")
                {
                    s[2] = "-";
                }
                result += s[2] + "y";
            }
            if (result=="")
            {
                result = "0";
            }
            Console.WriteLine(result);
        }
    }
}
