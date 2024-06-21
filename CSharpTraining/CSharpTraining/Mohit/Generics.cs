using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit
{
    // we use < > to specify Parameter type
    internal class Generics<ValueType>
    {
        private ValueType data;

        public ValueType Value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }

    class test
    {
        static void Main(string[] args)
        {
            Generics<string> name = new Generics<string>();
            name.Value = "Generic Class";

            Generics<int> number = new Generics<int>();
            number.Value = 1;

            Generics<float> version = new Generics<float>();
            version.Value = 2.3F;

            Console.WriteLine(name.Value);
            Console.WriteLine(number.Value);
            Console.WriteLine(version.Value);
        }
    }
}
