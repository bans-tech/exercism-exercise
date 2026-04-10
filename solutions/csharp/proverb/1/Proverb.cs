public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        int n = subjects.Length; //length of array
        string [] result = new string[n];

        if (n == 0) 
        {
            return result;
        }
        for (int i = 0; i < n - 1; i++)
        {
            result [i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";            
        }
        result[n - 1] = $"And all for the want of a {subjects[0]}.";
        return result;
    }
}