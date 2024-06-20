using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit
{
    abstract class Abstraction
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("zzzzzz...");
        }
    }

    class dog : Abstraction
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog says: Bow Wow");
        }
    }

    class Program
    {
        static void Main()
        {
            Abstraction abs = new dog();
            abs.animalSound();
            abs.sleep();
        }
    }
}
