using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        string pattern = @".*:\s(.*)";
        Match validMessage = Regex.Match(logLine, pattern);

        return validMessage.Success 
            ? validMessage.Groups[1].Value.Trim() 
            : logLine;
    }

    public static string LogLevel(string logLine)
    {
        string pattern = @"\[(.*?)\]";
        Match validMessage = Regex.Match(logLine, pattern);

        return validMessage.Success 
            ? validMessage.Groups[1].Value.Trim().ToLower() 
            : logLine;
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string levelMessage = LogLevel(logLine);
        
        string levelMessageReplaced = $"({levelMessage})";

        string messageConcatWithLevel = string.Join(' ', message, levelMessageReplaced);

        return messageConcatWithLevel;
    }
}
