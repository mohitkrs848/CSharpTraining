using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Sec1
{
    internal class _1C
    {
        static string stringLower(int position, string str)
        {
            return str.Substring(position).ToLower();
        }

        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter position: ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringLower(position, str));
        }
    }
}
