public class Anagram
{
    string targetWord = "";
    
    public Anagram(string baseWord)
    {
        targetWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> candidateWords = new List<string>();        
        string sortedTarget = Normalizer(targetWord);
        
        foreach (string potentialMatch in potentialMatches)
        {
            if (potentialMatch.ToLower() == targetWord.ToLower())
            {
                continue;
            }
            string sortedCandidate = Normalizer(potentialMatch);
            
            if (sortedTarget == sortedCandidate)
            {
                candidateWords.Add(potentialMatch);
            }
        } 
        return candidateWords.ToArray();
    }

    //Helper method
    public string Normalizer(string inputWord)
    {
        // Convert to lowercase -> character -> sort -> back to string.
        string inputLowcase = inputWord.ToLower();
        char[] inputChar = inputLowcase.ToCharArray();
        Array.Sort(inputChar);
        string input = new string(inputChar);
        return input;
    }
}