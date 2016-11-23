using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.BL;

namespace TestTask
{
    public class BaseEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double AverageMonthlySalary { get; set; }



        public BaseEmployee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }


        public virtual double Payroll()
        {
            return AverageMonthlySalary;
        }
    }
}
