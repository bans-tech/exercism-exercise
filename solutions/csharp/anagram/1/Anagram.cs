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
            if (potentialMatch.ToLower() == targetWord.ToLower())
            {
                continue;
            }
            // Normalize case (both words should be lowercase)
            string targetWordLower = targetWord.ToLower();
            string potentialMatchLower = potentialMatch.ToLower();

            // Convert string to character array
            char[] charTarget = targetWordLower.ToCharArray();
            char[] charCandidate = potentialMatchLower.ToCharArray();
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