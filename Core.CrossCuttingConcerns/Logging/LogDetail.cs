using Microsoft.Extensions.Logging;

namespace Core.CrossCuttingConcerns.Logging;

public class LogDetail(string fullName, string methodName, string user, List<LogParameter> parameters)
{
    public string FullName { get; set; } = fullName;
    public string MethodName { get; set; } = methodName;
    public string User { get; set; } = user;
    public List<LogParameter> Parameters { get; set; } = parameters;

    public LogDetail() : this(String.Empty, String.Empty, String.Empty, new List<LogParameter>())
    {
    }
}