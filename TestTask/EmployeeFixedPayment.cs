using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.BL;

namespace TestTask
{
    public class EmployeeFixedPayment : BaseEmployee
    {
        public double Salary { get; set; }

        public EmployeeFixedPayment(double salary, string name, string surname) :base(name,surname)
        {
            Salary = salary;
            PaymentMethod = PaymentMethod.FixedPayment;
            Id = GetLastId.GetId();
            Payroll();
        }

        public override double Payroll()
        {
            AverageMonthlySalary = Salary;
            return base.Payroll();
        }
    }
}
