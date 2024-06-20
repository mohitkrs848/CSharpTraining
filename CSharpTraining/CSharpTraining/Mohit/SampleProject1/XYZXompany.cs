using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.SampleProject1
{
    internal class XYZXompany
    {
        static void Main()
        {
            Employee alex = new Employee("Alex Rod", 6);
            Employee lynda = new Employee("Lynda Berry", 7);
            Employee john = new Employee("John Doe", 3);
            Employee sara = new Employee("Sara Time", 7);
            Employee james = new Employee("James", 7);

            Department sales = new Department("XYZ sales");
            sales.AddEmployee(alex);
            sales.AddEmployee(lynda);
            sales.AddEmployee(john);
            sales.Describe();

            Department IT = new Department("XYZ IT");
            IT.AddEmployee(sara);
            IT.AddEmployee(james);
            IT.Describe();
        }
    }
}
