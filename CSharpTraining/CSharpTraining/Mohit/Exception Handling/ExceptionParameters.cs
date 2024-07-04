using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit.Exception_Handling
{
    internal class ExceptionParameters
    {
        static void Main(string[] args)
        {
            try
            {
                // Simulate an exception
                ThrowException();
            }
            catch (Exception ex)
            {
                // Display the various properties of the Exception
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("\nStackTrace: " + ex.StackTrace);
                Console.WriteLine("\nInnerException: " + (ex.InnerException?.Message ?? "None"));
                Console.WriteLine("\nTargetSite: " + ex.TargetSite);
                Console.WriteLine("\nSource: " + ex.Source);
                Console.WriteLine("\nHelpLink: " + (ex.HelpLink ?? "None"));
                Console.WriteLine("\nHResult: " + ex.HResult);

                if (ex.Data.Count > 0)
                {
                    Console.WriteLine("Data:");
                    foreach (var key in ex.Data.Keys)
                    {
                        Console.WriteLine($"  {key}: {ex.Data[key]}");
                    }
                }
            }
        }

        static void ThrowException()
        {
            try
            {
                // Cause a divide by zero exception
                int zero = 0;
                int result = 5 / zero;
            }
            catch (DivideByZeroException ex)
            {
                // Create an exception with an inner exception
                var customException = new Exception("A custom error occurred.", ex);
                customException.HelpLink = "http://example.com/help";
                customException.Data.Add("AdditionalInfo", "Some additional info about the error");
                throw customException;
            }
        }
    }
}
