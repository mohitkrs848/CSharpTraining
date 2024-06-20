using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Inheritance
{
    sealed class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("peep, peep!");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Figo";
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
