public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int code = 0;
        string[] colors =new[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        
        code = Array.IndexOf(colors, color);
        return code;
    }

    public static string[] Colors()
    {
        string[] colors = new[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        
        foreach (string color in colors)
        {
            System.Console.Write(color);
        }  
        return colors;
    }
}