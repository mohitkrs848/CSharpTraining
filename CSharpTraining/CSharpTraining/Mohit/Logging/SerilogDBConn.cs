using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using Serilog.Sinks.MSSqlServer;

namespace CSharpTraining.Mohit.Logging
{
    public class SerilogDBConn
    {
        // Created one sql server using SQL Express
        // Select LocalDB through Media option
        // now run command in commandprompt 'sqllocaldb create "MyDemoDB"' to create a local db instance named as "MyDemoDB"
        // now start the instance using 'sqllocaldb start "MyDemoDB"'
        // now connect the instance from the SSMS2022 using the server name as (localdb)\MyDemoDB
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.MSSqlServer(
                    connectionString: "Server=(localdb)\\MyDemoDB;Database=SerilogDB;Integrated Security=True;",
                    sinkOptions: new MSSqlServerSinkOptions { TableName = "Logs", AutoCreateSqlTable = true },
                    restrictedToMinimumLevel: LogEventLevel.Information)
                .CreateLogger();

            // Log some test messages
            Log.Information("This is an information message.");
            Log.Warning("This is a warning message.");
            Log.Error("This is an error message.");
            Log.Fatal("This is a critical message.");

            // Flush and close the log
            Log.CloseAndFlush();
        }
    }
}
