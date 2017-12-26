using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Friends
    {
        public static void X()
        {

            string[] inputstr = Console.ReadLine().Split(' ');
            int CountHuman = int.Parse(inputstr[0]);
            int MainHuman =  int.Parse(inputstr[1]);
            int[,] Matrix = new int[CountHuman, CountHuman];
            for (int i = 0; i < CountHuman; i++)
            { 
                string[] CurrentHuman = Console.ReadLine().Split(' ');
                for (int j = 0; j < CountHuman; j++)
                { 
                    Matrix[i, j] =  int.Parse(CurrentHuman[j]);
                }
            }
            dfs d = new dfs(Matrix, MainHuman - 1, CountHuman,MainHuman-1);
                d.dfsmet(); 
            Console.WriteLine(d.Res()); 
        }


        class dfs
        {
            int[,] Matrix;
            int size;
            int result = 0;
            int main;
            //пути которые проверять
            List<int> path = new List<int>();

            public dfs(int[,] matrix,int start,int size,int main)
            {
                Matrix = matrix;
                path.Add(start);
                this.size = size;
                this.main = main;
            }
            List<int> friends = new List<int>();
            public void dfsmet()
            {
                while (path.Count > 0)
                {
                    for (int i = 0; i < size; i++)
                    {
                        //если от этого человека есть связь с каким то другим то добавить этого человека в пути 
                        //добавить 1 к результату и убрать связь с этим человеком(чтобы 2 раз не проходил)
                        //также добавляеть только в том случае если его ещё нету в списке результатов
                        if (Matrix[i, path[0]] == 1)
                        {

                            //обнуляем связь
                            Matrix[i, path[0]] = 0;
                            //если ещё нет в результатах
                            if (!friends.Contains(i) && i!=main)
                            {
                                friends.Add(i);
                                path.Add(i);
                                result++;
                            }
                        }
                    }
                    //удаляем того кто проверен
                    path.RemoveAt(0); 
                }
            } 
             public int Res()
            {
                return result;
            }


        }
    }
}
