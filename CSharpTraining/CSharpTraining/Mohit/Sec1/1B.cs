using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Sec1
{
    internal class _1B
    {
        static void arrSum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum: " + sum);
        }

        static void Main()
        {
            Console.WriteLine("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            arrSum(arr);
        }
    }
}
