using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OlimpicProject
{
    class ForGenerationTest
    {  
        public static void Mains()
        { 
            StreamWriter sw = new StreamWriter("input.txt");
            Random r = new Random(); 
            sw.WriteLine(5); 
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine(100000 + " " + 100000);
                for (int j = 0; j < 100000; j++)
                {
                    sw.Write(r.Next(1,1000000000)+" ");
                }
                sw.WriteLine();
                for (int k = 0; k < 100000; k++)
                {
                    sw.WriteLine(r.Next(1, 1000000000) + " ");
                } 
            }
            
             
            sw.Close();
        }
        public static void x636()
        {
            StreamWriter sw = new StreamWriter("input636.txt");

            sw.WriteLine(50000);
            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 25001; j++)
                {
                    sw.WriteLine(i+" "+j);
                } 
            }


            sw.Close();
        }

        internal static void x216()
        {

            StreamWriter sw = new StreamWriter("input216.txt");

            sw.WriteLine(1000);

           
                for (int j = 1; j < 1001; j++)
                {
                    sw.Write(j + " ");
                }  

            sw.Close();
        }

        public static void ForTCC1_3()
        {
            StreamWriter sw = new StreamWriter("input.txt");
            Random r = new Random();
            sw.WriteLine(5);
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine(100000 + " " + 100000);
                for (int j = 0; j < 100000; j++)
                {
                    sw.Write(r.Next(1, 1000000000) + " ");
                }
                sw.WriteLine();
                for (int k = 0; k < 100000; k++)
                {
                    sw.WriteLine(r.Next(1, 1000000000) + " ");
                }
            } 
            sw.Close();

        }

        internal static void x41()
        {
            StreamWriter sw = new StreamWriter("input.txt");
            Random r = new Random();
            sw.WriteLine(1000000);
            for (int i = 0; i < 1000000; i++)
            {
                sw.Write(r.Next(-100, 100) + " ");
            }
            sw.Close();
        }
    }
} 
