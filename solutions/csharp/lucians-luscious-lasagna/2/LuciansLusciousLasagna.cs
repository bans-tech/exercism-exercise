class Lasagna
{
    int expectedOvenTime = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {        
        return expectedOvenTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven)
    {
        return expectedOvenTime - minutesInOven;
        RemainingMinutesInOven(30);
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return numberOfLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)
    {        
        return PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
        ElapsedTimeInMinutes(3, 20);
    }
}
