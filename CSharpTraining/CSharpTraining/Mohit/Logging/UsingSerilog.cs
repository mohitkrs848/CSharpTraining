using Serilog;

namespace CSharpTraining.Mohit.Logging
{
    public class UsingSerilog
    {
        static void Main(string[] args)
        {
            // Configure Serilog for file logging
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/log.txt")
                .WriteTo.Console()
                .CreateLogger();

            // Log messages using Serilog logger
            var logger = Log.Logger;
            logger.Information("This is an information message.");
            logger.Warning("This is a warning message.");
            logger.Error("This is an error message.");
            logger.Fatal("This is a critical message.");

            // Ensure all logs are flushed and resources are released
            Log.CloseAndFlush();
        }
    }
}
