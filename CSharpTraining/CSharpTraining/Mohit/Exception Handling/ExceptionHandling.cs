using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit
{
    internal class ExceptionHandling
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == 0)
                {
                    throw new DivByZeroException();
                }

                // Potential division by zero
                int result = 100 / number;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input is not a valid number. Please enter a valid integer.");
            }
            catch (DivByZeroException ex)
            {
                Console.WriteLine("Division by zero is not allowed. Please enter a non-zero integer.");
            }
            catch (Exception ex)
            {
                // General exception handler for any other exceptions
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution of the try-catch block is complete.");
            }
        }
    }

    class DivByZeroException : Exception
    {
        public DivByZeroException()
        {
            
        }
    }
}
