using System; 
using System.Linq; 

namespace OlimpicProject.ParsingString
{
    class SubstringOfSomeLetter
    {
        public static void X() {
            string STR = Console.ReadLine();
            string a = "qwertyuiopasdfghjklzxcvbnm";
            int CurrentMaxLetterSome = 0;

            //проходим по всем буквам алфавита
            for (int i = 0; i < a.Length; i++)
            {
                string currentletter = a[i].ToString();
                // смотрим какая позиция у первого и последнего 
                int FirstPosition = STR.IndexOf(currentletter);
                int LastPosition = STR.LastIndexOf(currentletter);
                //если такой символ есть
                if (FirstPosition >= 0)
                {
                    //смотрим на разницу между символами
                    if (LastPosition - FirstPosition > CurrentMaxLetterSome)
                    {
                        CurrentMaxLetterSome = LastPosition - FirstPosition;
                    }
                }
            }
            Console.WriteLine(CurrentMaxLetterSome);
             
        }
        
    }
}
