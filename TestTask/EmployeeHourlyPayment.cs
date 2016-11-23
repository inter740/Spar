using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.BL;

namespace TestTask
{
    public class EmployeeHourlyPayment : BaseEmployee
    {
        public double HourlyRate { get; set; }

        public EmployeeHourlyPayment(string name, string surname,double rate):base(name,surname)
        {
            HourlyRate = rate;
            Id = GetLastId.GetId();
            Payroll();
        }

        public override double Payroll()
        {
            AverageMonthlySalary = 20.8*8*HourlyRate;
            return base.Payroll();
        }
    }
}
