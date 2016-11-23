using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestTask.BL
{
    public static class ReturnEmployes
    {


        public static List<BaseEmployee> Get()
        {
            List<BaseEmployee> Employee = new List<BaseEmployee>();

            using (StreamReader fs = new StreamReader(@"employesList.txt"))
            {
                var numberOfLine = 0;
                while (true)
                {
                    try
                    {
                        string temp = fs.ReadLine();


                        if (temp == null)
                        {
                            if (Employee.Count == 0) Console.WriteLine("Файл с работниками пуст");

                            break;
                        }


                        JObject json = JObject.Parse(temp);

                        JsonSerializer serializer = new JsonSerializer();
                        if (json != null)
                        {
                            BaseEmployee employee = serializer.Deserialize<BaseEmployee>(json.CreateReader());

                            Employee.Add(employee);
                            numberOfLine++;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ошибка чтения файла на {0} строке", numberOfLine);
                        Console.WriteLine();
                    }


                }

            }


            var sortedEmployes = from e in Employee
                                 orderby e.AverageMonthlySalary descending, e.Name
                                 select e;

            return sortedEmployes.ToList();

        }

        public static List<BaseEmployee> GetFirstFiveEmployes(List<BaseEmployee> employes)
        {
            var emp = employes.Take(5).ToList();

            return emp;
        }

        public static List<BaseEmployee> GetLastThreeEmployes(List<BaseEmployee> employes)
        {
            var emp = Enumerable.Reverse(employes).Take(3).Reverse().ToList();
            return emp;
        }
    }
}
