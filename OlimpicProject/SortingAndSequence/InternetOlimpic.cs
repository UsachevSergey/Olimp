using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class InternetOlimpic
    {
        public static void X()
        {
            string S = Console.ReadLine();
            int CountCommantFirstDivision = int.Parse(S.Split(' ')[0]);
            int CountCommantSecondDivision = int.Parse(S.Split(' ')[1]);
            List<Comand> CMFirst = new List<Comand>();
            List<Comand> CMSecond = new List<Comand>();
            
            //заполняем масивы команд первого и второго дивизиона
            for (int i = 0; i < CountCommantFirstDivision; i++)
            {
                string s = Console.ReadLine();
                Comand C = new Comand();
                C.Id = int.Parse(s.Split(' ')[0]);
                C.CompletedAssignments = int.Parse(s.Split(' ')[1]);
                C.PenaltyTime = int.Parse(s.Split(' ')[2]);
                if (C.CompletedAssignments>0)
                { 
                    //добавляем только решивших хотябы 1
                    CMFirst.Add(C);
                } 
            }
            //прошедшие команды
            List<int> IDComandWIN = new List<int>();

            for (int i = 0; i < CountCommantSecondDivision; i++)
            {
                string s = Console.ReadLine();
                Comand C = new Comand();
                C.Id = int.Parse(s.Split(' ')[0]);
                C.CompletedAssignments = int.Parse(s.Split(' ')[1]);
                C.PenaltyTime = int.Parse(s.Split(' ')[2]);
                if (C.CompletedAssignments > 0)
                {
                    //добавляем только решивших хотябы 1
                    IDComandWIN.Add(C.Id);
                }
            }

           
            //сортируем по количеству балов и штрафному времени
         CMFirst=CMFirst.OrderByDescending(asa => asa.CompletedAssignments).ThenBy(assa => assa.PenaltyTime).ToList();
            int MaxComplete = 0;
            if (CMFirst.Count>0)
            {
                MaxComplete = CMFirst[0].CompletedAssignments;
            } 

            //добавляем всех кто выполнил столькоже сколько победитель
            foreach (var item in CMFirst)
            {
                if (item.CompletedAssignments== MaxComplete)
                {
                    IDComandWIN.Add(item.Id);
                } 
            }
            //середина списка
            int CentepPlace = CMFirst.Count()/2-1;
            int CenterCountComplete = 9999;
            if (CentepPlace>0)
            {
                CenterCountComplete = CMFirst[CentepPlace].CompletedAssignments;
            } 

             

            //добавляем всех кто до середины и набрал больше балов чем центральный
            for (int i = 0; i < CentepPlace; i++)
            {
                if (CMFirst[i].CompletedAssignments>CenterCountComplete)
                { 
                    IDComandWIN.Add(CMFirst[i].Id);
                } 
            }

            IDComandWIN= IDComandWIN.Distinct().ToList();

            IDComandWIN.Sort();

            Console.WriteLine(IDComandWIN.Count);
            foreach (var id in IDComandWIN)
            {
                Console.Write(id+" ");
            }
            Console.WriteLine(); 
        }

        struct Comand
        {
         public int Id,CompletedAssignments,PenaltyTime;
        }

    }
}
