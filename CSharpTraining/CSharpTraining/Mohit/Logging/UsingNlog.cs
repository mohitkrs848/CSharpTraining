using NLog;
using NLog.Config;
using NLog.Targets;

class UsingNlog
{
    static void Main(string[] args)
    {
        // Configure NLog programmatically
        var config = new LoggingConfiguration();
        var fileTarget = new FileTarget("fileTarget") { FileName = "logs/nlog.txt" };
        config.AddRule(LogLevel.Info, LogLevel.Fatal, fileTarget);

        LogManager.Configuration = config;

        // Get logger instance
        var logger = LogManager.GetCurrentClassLogger();
        logger.Info("Info message");
        logger.Warn("Warning message");
        logger.Error("Error message");
        logger.Fatal("Fatal message");
    }
}