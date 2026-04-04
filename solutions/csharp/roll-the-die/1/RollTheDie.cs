public class Player
{
    public int RollDie()
    {
        Random randObj = new Random();
        
        return randObj.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        Random rnd = new Random();
        return rnd.NextDouble() * 100.0;
    }
}
