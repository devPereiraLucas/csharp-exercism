using System;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        string pattern = @".*:\s(.*)";
        Match validMessage = Regex.Match(logLine, pattern);
        string trimedMessage = validMessage.Groups[1].Value.Trim();

        return validMessage.Success ? trimedMessage : logLine;
    }

    public static string LogLevel(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
