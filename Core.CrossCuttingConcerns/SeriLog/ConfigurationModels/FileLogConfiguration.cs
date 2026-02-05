namespace Core.CrossCuttingConcerns.SeriLog.ConfigurationModels;

public class FileLogConfiguration(string folderPath)
{
    public string FolderPath { get; set; } = folderPath;

    public FileLogConfiguration() : this(String.Empty)
    {
    }
}