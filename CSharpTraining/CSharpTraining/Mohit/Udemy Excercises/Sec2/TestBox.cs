using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Sec2
{
    internal class TestBox
    {
        static void Main()
        {
            Box ups, fedEx;
            ups = new Box();
            fedEx = new Box();

            ups.length = 10;
            ups.breadth = 20;
            ups.CalculateArea(20, 30);

            fedEx.length = 15;
            fedEx.breadth = 25;
            fedEx.CalculateArea(30, 10);
        }
    }
}
