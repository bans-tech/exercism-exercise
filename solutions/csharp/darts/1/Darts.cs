public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
       if (distance <= 1)
       {
           return (int)10;
       }
        else if (distance <= 25)
        {
            return (int)5;
        }
        else if (distance <= 100)
        {
            return (int)1;
        }
        else
        {
            return 0;
        }
    }
}
