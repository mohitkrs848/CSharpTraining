using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Encapsulation
{
    internal class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee lynda = new Employee();

            alex.SetSalary(90000);
            alex.CalculateTotalPay();

            lynda.SetSalary(1000000);
            lynda.CalculateTotalPay();
        }
    }
}
