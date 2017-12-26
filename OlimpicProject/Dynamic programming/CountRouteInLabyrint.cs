using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountRouteInLabyrint
{
    public static void X()
    {
        string[] s = Console.ReadLine().Split();
        int MN = int.Parse(s[0]);
        int Countstep = int.Parse(s[1]);
        int[,] Matrix = new int[MN, MN]; 
        for (int i = 0; i < MN; i++)
        {
            string currents = Console.ReadLine();
            for (int j = 0; j < MN; j++)
            {
                if (currents[j] =='1')
                {
                    Matrix[i, j] = -99999;
                }
                else
                {
                    Matrix[i, j] = 0;
                }
            }
        }
        //тут заполнено
        bool Even = true;
        int carry = 0;
        Matrix[0, 0] = 1;



        for (int a = 0; a < Countstep; a++)
        {
            Even = !Even;
            //остаток
            if (Even)
            {
             carry = 0;
            }
            else
            {
                carry = 1;
            }  
            for (int i = 0; i < MN; i++)
            {
                for (int j = 0; j < MN; j++)
                {
                    //расматриваем только четные/нечетные. В зависимости от номера шага
                    if ( (i+j)%2==carry && Matrix[i,j]!=-99999)
                    {
                        int up = 0, left = 0, down = 0, right = 0;
                        try
                        {
                            if (Matrix[i-1, j] != -99999)
                            {
                                up = Matrix[i-1, j];
                            }
                        }
                        catch { }
                        try
                        {
                            if (Matrix[i+1, j] != -99999)
                            {
                                down = Matrix[i+1, j];
                            }
                        }
                        catch { }
                        try
                        {
                            if (Matrix[i, j-1] != -99999)
                            {
                                left = Matrix[i, j-1];
                            }
                        }
                        catch { }
                        try
                        {
                            if (Matrix[i, j+1] != -99999)
                            {
                                right = Matrix[i, j+1];
                            }
                        }
                        catch { } 
                        Matrix[i, j] = up + down + right + left; 
                    }
                } 
            }  
        }


        if (Countstep%2==0)
        {

            Console.WriteLine(Matrix[MN - 1, MN - 1]);
        }
        else
        {
            Console.WriteLine(0);
        } 


    }

}