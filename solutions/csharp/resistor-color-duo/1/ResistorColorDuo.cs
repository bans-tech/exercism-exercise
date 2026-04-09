public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        int colorValue = 0;
        string[] bandColors = new[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

        int firstInputColor = Array.IndexOf(bandColors, colors[0]);
        int secondInputColor = Array.IndexOf(bandColors, colors[1]);
        colorValue = (firstInputColor * 10) + secondInputColor;
        return colorValue;
    }
}
