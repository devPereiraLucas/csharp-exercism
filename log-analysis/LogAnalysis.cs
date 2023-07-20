using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string param) 
        => str[(str.IndexOf(param) + param.Length)..];

    public static string SubstringBetween(this string str, string param1, string param2)
        => str[(str.IndexOf(param1) + param1.Length)..str.IndexOf(param2)];

    public static string Message(this string str)
        => str[(str.IndexOf(":") + 2)..];
    
    public static string LogLevel(this string str) 
        => str.SubstringBetween("[", "]");
}