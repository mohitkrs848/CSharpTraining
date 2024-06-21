using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit
{
    class Delegates
    {
        public delegate void addNum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        
        public void sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a-b}");
        }

        public static void Main(string[] args)
        {
            Delegates obj = new Delegates();

            addNum delegate_obj_add = new addNum(obj.sum);
            delegate_obj_add += new addNum(obj.sub);
            addNum delegate_obj_sub = new addNum(obj.sub);

            delegate_obj_add(10, 20);
            delegate_obj_sub(10, 20);
        }
    }
}
