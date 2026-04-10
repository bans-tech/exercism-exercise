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
        
        foreach (string potentialMatch in potentialMatches)
        {
            // Normalize case (both words should be lowercase)
            string targetWordLowcase = targetWord.ToLower();
            string potentialMatchLowcase = potentialMatch.ToLower();
            
            if (potentialMatchLowcase == targetWordLowcase)
            {
                continue;
            }
            
            // Convert string to character array
            char[] charTarget = targetWordLowcase.ToCharArray();
            char[] charCandidate = potentialMatchLowcase.ToCharArray();
            // Sort characters alphabetically.
            Array.Sort(charTarget);
            Array.Sort(charCandidate);

            // Convert sorted characters to string.
            string sortedTarget = new string(charTarget);
            string sortedCandidate = new string(charCandidate);

            if (sortedTarget == sortedCandidate)
            {
                candidateWords.Add(potentialMatch);
            }
        } 
        return candidateWords.ToArray();
    }
}