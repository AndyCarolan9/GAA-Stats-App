namespace StatsTracker.Utils;

public enum MessageType
{
    Log,
    Warning,
    Error
}

public class LogSystem
{
    private static readonly string LogFile = "Logs.txt";
    
    public static void Log(MessageType type, string message)
    {
        string newMessage = type.ToString() + ": " + message;

        if (type == MessageType.Error)
        {
            Console.Error.WriteLine(newMessage);
        }
        else
        {
            Console.WriteLine(newMessage);
        }
        
        WriteToLog(newMessage);
    }

    private static void WriteToLog(string message)
    {
        string filePath = JSONHelper.GetFilePath(LogFile);
        File.AppendAllText(filePath, message + Environment.NewLine);
    }

    public static void ClearLog()
    {
        string filePath = JSONHelper.GetFilePath(LogFile);
        File.Delete(filePath);
    }
}