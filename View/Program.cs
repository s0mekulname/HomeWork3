// Author: Boinskii Alexei

using System;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            // UI001 
            // При старте приложения запросить у пользователя количество  
            // чисел для решения спора – целое число больше ноля. 
            // При ошибке ввода запросить число снова
            while (true)
            {
                Console.WriteLine("Please, enter number of rounds > 0 ");
                int.TryParse(Console.ReadLine(), out n);
                if (n > 0) break;
                Console.WriteLine("Wrong Input.");
            }

            var numbertron = new Numbertron();
            var jay = new Jay();
            var silentBob = new SilentBob();

            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += silentBob.FetchNewNumber;

            // UI002 
            // По результатам генерации вывести имя победителя 
            // или слово DRAW в случае ничьей
            for (var i = 0; i < n; i++) numbertron.Generate();
            var  res = jay.Score - silentBob.Score;
            if      (res > 0)   Console.WriteLine("Jay wins!");          
            else if (res < 0)   Console.WriteLine("Silent Bob wins!");            
            else                Console.WriteLine("DRAW");

            Console.WriteLine("Press \"Enter\" to close the program.");
            Console.ReadLine();
        }
    }
}
