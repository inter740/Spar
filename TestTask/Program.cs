using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.BL;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var command = "";

                Console.WriteLine("Введите номер команды:");
                Console.WriteLine("1 - Вывести в консоль упорядоченную последовательность работников по убыванию среднемесячного заработка.");
                Console.WriteLine("2 - Добавить сотрудника с фиксированной заработной платой");
                Console.WriteLine("3 - Добавить сотрудника с почасовой оплатой");
                Console.WriteLine("4 - Выход");
                Console.WriteLine();

                command = Console.ReadLine();

                if (command == "4")
                {
                    break;
                }

                ConsoleInputProcessing.ParseCommand(command);
                Console.WriteLine("_______________________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
