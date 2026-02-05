namespace Core.CrossCuttingConcerns.Logging;

public class LogParameter(string name, object value, string type)
{
    public string Name { get; set; } = name;
    public object Value { get; set; } = value;
    public string Type { get; set; } = type;

    public LogParameter() : this(String.Empty, String.Empty, String.Empty)
    {
    }
}