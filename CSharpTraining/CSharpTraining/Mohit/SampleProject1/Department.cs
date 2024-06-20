using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.SampleProject1
{
    public class Department
    {
        private string deptName;
        private double deptBudget;
        private int counter = 0;

        Employee[] emps = new Employee[5];

        public void AddEmployee(Employee obj)
        {
            emps[counter] = obj;
            counter++;
            if (obj.empGrade > 5)
            {
                deptBudget += 150000;
            }
            else
            {
                deptBudget += 100000;
            }
        }

        public void Describe()
        {
            string temp = "Department Name: " + deptName + " || Department Budget: " + deptBudget + "\n Employees :  ";
            foreach (Employee employee in emps)
            {
                if (employee == null)
                {
                    break;
                }
                temp += employee.ReturnNameGrade() + " ";
            }
            Console.WriteLine(temp);
        }

        public Department(string deptName)
        {
            this.deptName = deptName;
            deptBudget = 50000;
        }
    }
}
