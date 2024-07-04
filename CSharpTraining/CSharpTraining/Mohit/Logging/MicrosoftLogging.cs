using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CSharpTraining.Mohit.Logging
{
    public class MicrosoftLogging
    {
        // Declare a readonly logger instance
        private readonly ILogger<MicrosoftLogging> _logger;

        // Constructor to inject the logger instance
        public MicrosoftLogging(ILogger<MicrosoftLogging> logger)
        {
            _logger = logger;
        }

        // Method to log messages at different log levels
        public void LogSomething()
        {
            // Log various log levels using the logger instance
            _logger.LogTrace("This is a trace message.");         // Log a trace-level message (lowest severity)
            _logger.LogDebug("This is a debug message.");         // Log a debug-level message
            _logger.LogInformation("This is an information message."); // Log an information-level message
            _logger.LogWarning("This is a warning message.");     // Log a warning-level message
            _logger.LogError("This is an error message.");        // Log an error-level message
            _logger.LogCritical("This is a critical message.");   // Log a critical-level message (highest severity)
        }

        // Entry point of the application
        static void Main(string[] args)
        {
            //build using configuration from appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath("C:\\Users\\Kumar.Mohit\\source\\repos\\mohitkrs848\\CSharpTraining\\CSharpTraining\\CSharpTraining")
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Set up the logger factory
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                .AddConsole()                 // Add console logging
                .SetMinimumLevel(LogLevel.Trace) // Set the minimum log level to Trace
                .AddConfiguration(configuration.GetSection("Logging"));    //Set the configuration (Configuration setting will override the code setting)
            });

            // Create a logger instance for MicrosoftLogging
            var logger = loggerFactory.CreateLogger<MicrosoftLogging>();

            // Create an instance of MicrosoftLogging and call LogSomething method
            var microsoftLogging = new MicrosoftLogging(logger);
            microsoftLogging.LogSomething();
        }
    }
}
