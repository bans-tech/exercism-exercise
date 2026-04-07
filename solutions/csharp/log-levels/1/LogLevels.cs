static class LogLine
{
    public static string Message(string logLine) 
    {
        int first = logLine.IndexOf(":");
        string message = logLine.Substring(first + 2);
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf("[");
        int atIndex = logLine.IndexOf("]");
        string logLevel = logLine.Substring(startIndex + 1, atIndex - 1);
        return ($"{logLevel}").ToLower();
    }

    public static string Reformat(string logLine)
    {
        //Use the already defined methods above.
        return ($"{Message(logLine)} ({LogLevel(logLine)})");
    }
}
