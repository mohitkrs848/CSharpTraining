using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Sound!!!");
        }

        public void animalSound2()
        {
            Console.WriteLine("Sound!!!");
        }

        public string color = "white";
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog says: Bow Wow");
        }

        public string color = "black";
    }

    class polymorphism
    {
        static void Main()
        {
            Animal Animal = new Animal();
            Dog dog = new Dog();
            dog.animalSound();
            dog.animalSound2();
            Console.WriteLine(dog.color);
        }
    }
}
