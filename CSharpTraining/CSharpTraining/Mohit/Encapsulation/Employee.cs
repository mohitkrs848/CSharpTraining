using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Encapsulation
{
    public class Employee
    {
        private double salary;
        public double bonus { private set; get; }

        public void SetSalary(int salary)
        {
            if (salary < 40000 || salary > 150000)
            {
                Console.WriteLine("{lease check salary");
                this.salary = 0;
                this.salary = 0;
            }
            else
            {
                this.salary = salary;
                bonus = salary * .20;
            }
        }
        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total Pay: " + totalPay);
        }
    }
}
