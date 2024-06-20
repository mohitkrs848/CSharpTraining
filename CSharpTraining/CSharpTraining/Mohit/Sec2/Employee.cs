using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Sec2
{
    public class Employee
    {
        public double salary;
        public double bonus;

        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total Pay: " + totalPay);
        }
    }
}
