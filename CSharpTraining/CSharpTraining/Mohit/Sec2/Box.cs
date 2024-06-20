using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Sec2
{
    internal class Box
    {
        public double length;
        public double breadth;

        public void CalculateArea(int length, int breadth)
        {
            double area = this.length * breadth;
            Console.WriteLine("Area: " + area);
        }

    }
}
