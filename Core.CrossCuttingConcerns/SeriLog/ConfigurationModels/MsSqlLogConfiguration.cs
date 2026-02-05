namespace Core.CrossCuttingConcerns.SeriLog.ConfigurationModels;

public class MsSqlLogConfiguration(string connectionString, string tableName, bool autoCreateSqlTable)
{
    public string ConnectionString { get; set; } = connectionString;
    public string TableName { get; set; } = tableName;
    public bool AutoCreateSqlTable { get; set; } = autoCreateSqlTable;

    public MsSqlLogConfiguration() : this(String.Empty, String.Empty, false)
    {
    }
}