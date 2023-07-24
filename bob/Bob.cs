using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.IsSilence())
            return "Fine. Be that way!";

        if (statement.IsYelling() && statement.IsQuestion())
            return "Calm down, I know what I'm doing!";

        if (statement.IsYelling())
            return "Whoa, chill out!";

        if (statement.IsQuestion()) return "Sure.";

        return "Whatever.";

    }

    private static bool IsQuestion(this string message)
        => message.TrimEnd().EndsWith("?");

    private static bool IsYelling(this string message)
        => message.Any(char.IsLetter) && message.ToUpperInvariant() == message;

    private static bool IsSilence(this string message)
        => string.IsNullOrWhiteSpace(message);
    
}