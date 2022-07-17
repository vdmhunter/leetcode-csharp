namespace LeetCodeCSharpApp.MinimumDeletionsToMakeCharacterFrequenciesUnique03;

public class Solution
{
    /// <summary>
    /// Sorting
    /// </summary>
    public int MinDeletions(string s)
    {
        // Store the frequency of each character
        var frequency = new int[26];
        foreach (var c in s)
            frequency[c - 'a']++;

        Array.Sort(frequency);

        var deleteCount = 0;

        // Maximum frequency the current character can have
        var maxFreqAllowed = s.Length;

        // Iterate over the frequencies in descending order
        for (var i = 25; i >= 0 && frequency[i] > 0; i--)
        {
            // Delete characters to make the frequency equal the maximum frequency allowed
            if (frequency[i] > maxFreqAllowed)
            {
                deleteCount += frequency[i] - maxFreqAllowed;
                frequency[i] = maxFreqAllowed;
            }

            // Update the maximum allowed frequency
            maxFreqAllowed = Math.Max(0, frequency[i] - 1);
        }

        return deleteCount;
    }
}
