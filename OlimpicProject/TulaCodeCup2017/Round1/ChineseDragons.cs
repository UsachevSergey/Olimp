using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TulaCodeCup2017.Round1
{
    class ChineseDragons
    {
        public static void X()
        {
            int CountReport = int.Parse(Console.ReadLine());
            for (int i = 0; i < CountReport; i++)
            {
                string result = "Valid";
                string LastInfoDragon = ".";
                int CountMark = int.Parse(Console.ReadLine());
                string Datemark = Console.ReadLine();
                for (int ii = 0; ii < CountMark; ii++)
                {
                    string curentM = Datemark[ii].ToString();
                    if (curentM == ".")
                    {

                    }
                    else if (curentM == "B") //голова
                    {
                        if (LastInfoDragon == "B")
                        {
                            result = "Invalid";
                            break;
                        }
                        else
                        {
                            LastInfoDragon = "B";
                        }
                    }
                    else
                    {
                        if (LastInfoDragon == "E" || LastInfoDragon == ".")
                        {
                            result = "Invalid";
                            break;
                        }
                        else
                        {
                            LastInfoDragon = "E";
                        }
                    }

                }
                if (LastInfoDragon == "B")
                {
                    result = "Invalid";
                }
                Console.WriteLine(result);
            }

            Console.ReadLine();

        }
    }
}
