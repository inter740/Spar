using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestTask.BL
{
    public static class ConsoleInputProcessing
    {
        public static void ParseCommand(string command)
        {
            if (command == "1")
            {
                var employes = ReturnEmployes.Get();

                foreach (var emp in employes)
                {
                    Console.WriteLine("Идентификатор: {0},  Имя: {1},  среднемесячный заработок: {2}", emp.Id, emp.Name, emp.AverageMonthlySalary);
                }
                Console.WriteLine("");

                if (employes.Count!=0)
                {
                    Console.WriteLine("Первые 5 сотрудников из списка:");
                    foreach (var emp in ReturnEmployes.GetFirstFiveEmployes(employes))
                    {
                        Console.WriteLine(emp.Name);
                    }
                    Console.WriteLine("");

                    Console.WriteLine("Идентификатор 3х последних сотрудников из списка:");
                    foreach (var emp in ReturnEmployes.GetLastThreeEmployes(employes))
                    {
                        Console.WriteLine(emp.Id);
                    }
                    Console.WriteLine("");
                }

            }

            if (command=="2")
            {
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Укажите сумму оклада: ");
                string sal = Console.ReadLine();

                double salary = 0;
                try
                {
                    salary = Double.Parse(sal);
                    EmployeeFixedPayment emp = new EmployeeFixedPayment(salary, name, surname);
                    AddEmployee.Add(emp);
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено не корректное значение зарплаты");
                }
                
            }

            if (command == "3")
            {
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Укажите часовую ставку: ");
                string rate = Console.ReadLine();
                double hourlyRate = 0;
                try
                {
                    hourlyRate=Double.Parse(rate);
                    EmployeeHourlyPayment emp = new EmployeeHourlyPayment(name, surname, hourlyRate);
                    AddEmployee.Add(emp);
                }
                catch (Exception)
                {
                    
                    Console.WriteLine("Введенна не корректная часавая ставка");
                }


            }

        }

    }
}
