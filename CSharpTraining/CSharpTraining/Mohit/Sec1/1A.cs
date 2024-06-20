using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Sec1
{
    public class _1A
    {
        static void taxCal(double salary)
        {
            double tax = 0;
            if (salary <= 8350)
            {
                tax = salary * 10 / 100;
            }
            else if (salary <= 33950 && salary > 8350)
            {
                tax = 8350 * 10 / 100 + (salary - 8350) * 15 / 100;
            }
            else if (salary > 33950)
            {
                tax = 8350 * 10 / 100 + (33950 - 8350) * 15 / 100 + (salary - 33950) * 25 / 100;
            }

            Console.WriteLine("Tax: " + tax);
        }

        static void Main()
        {
            Console.WriteLine("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            taxCal(salary);
        }
    }
}
