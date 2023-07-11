using System;
using System.Reflection.Emit;
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
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
