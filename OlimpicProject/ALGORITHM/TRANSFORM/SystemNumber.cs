using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.TRANSFORM
{
    class SystemNumber
    {
        /// <summary>
        /// передод из одной системы счисления в другуюы
        /// </summary>
        /// <param name="Number">число которое нужно перевести</param>
        /// <param name="startSystem">начальная система сисления</param>
        /// <param name="endSystem">конечная система счисления</param>
        /// <returns>вцйц</returns>
        public static string X(string Number,int startSystem,int endSystem)
        {
            //шаблон для поиска цифр букв
            string Pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //приводим к верхнему регистру
            Number = Number.ToUpper();


            //сначала переводим в десятичную систему.
            double TEN = 0;
            //проходим по всему числу(посимвольно)
            for (int i = 0; i < Number.Length; i++)
            {
                TEN += Pattern.IndexOf(Number[i]) * Math.Pow(startSystem, Number.Length - 1-i);
            }

            //для хранения нового числа
            List<string> newNumber = new List<string>();
            //переводим из десятичной в требуемую
            while (TEN>=endSystem)
            {
                //получаем остаток
                int carry =(int)TEN%endSystem;
                newNumber.Add(Pattern[carry].ToString());
                TEN /= endSystem;


            }
            //если есть последний остаток добавляем его
            if (TEN!=0)
            {
                newNumber.Add(Pattern[(int)TEN].ToString());
            }
            string Result = "";
            //переписываем полученые сиволы в обратном порядке и возвращаем строку
            foreach (var item in newNumber)
            {
                Result = item + "" + Result;
            }


            return Result;
        }
        
    }
}
