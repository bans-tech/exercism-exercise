class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int [] birdsPerWeek = [0, 2, 5, 3, 7, 8, 4];
        return birdsPerWeek;
    }

    public int Today()
    {
        this.birdsPerDay = birdsPerDay;
        int birdsToday = birdsPerDay.Length - 1;
        return birdsPerDay[birdsToday];
    }

    public void IncrementTodaysCount()
    {
        int lastIndex = birdsPerDay.Length - 1;
        birdsPerDay[lastIndex] = birdsPerDay[lastIndex] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var count in birdsPerDay)
        {
            if (count == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {            
            totalBirds = birdsPerDay[i] + totalBirds;            
        }
        return totalBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (var count in birdsPerDay)
        {
            if (count >= 5)
            {
                busyDays = busyDays + 1;
            }                     
        }
        return busyDays;
    }
}
