using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestTask.BL
{
    public static class AddEmployee
    {

        public static void Add(BaseEmployee employee)
        {
            var json = JsonConvert.SerializeObject(employee);
            string temp;

            using (StreamReader fs = new StreamReader(@"employesList.txt"))
            {
                temp = fs.ReadLine();
            }


            if (temp == null)
            {
                System.IO.File.AppendAllText(@"employesList.txt", json);
            }
            else
            {
                System.IO.File.AppendAllText(@"employesList.txt", Environment.NewLine + json);
            }

            Console.WriteLine("Был добавлен сотрудник: {0} {1}", employee.Name, employee.Surname);

        }
    }
}
