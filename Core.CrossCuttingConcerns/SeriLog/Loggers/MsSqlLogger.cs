using Core.CrossCuttingConcerns.SeriLog.ConfigurationModels;
using Core.CrossCuttingConcerns.SeriLog.Messages;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace Core.CrossCuttingConcerns.SeriLog.Loggers;

public class MsSqlLogger:LoggerServiceBase
{
    public MsSqlLogger(IConfiguration configuration)
    {
        MsSqlLogConfiguration logConfiguration =
            configuration.GetSection("SeriLogConfigurations:MsSqlLogConfiguration").Get<MsSqlLogConfiguration>()
            ?? throw new Exception(SeriLogMessages.NullOptionsMessage);

        MSSqlServerSinkOptions sinkOptions = new()
        {
            TableName = logConfiguration.TableName.Split(".")[1], AutoCreateSqlDatabase = logConfiguration.AutoCreateSqlTable,
            SchemaName = logConfiguration.TableName.Split(".")[0]
        };

        ColumnOptions columnOptions = new();

        global::Serilog.Core.Logger seriLogConfig = new LoggerConfiguration().WriteTo
            .MSSqlServer(logConfiguration.ConnectionString,sinkOptions,columnOptions:columnOptions)
            .CreateLogger();

        Logger = seriLogConfig;
    }
}