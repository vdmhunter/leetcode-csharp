namespace LeetCodeCSharpApp.MinimumDeletionsToMakeCharacterFrequenciesUnique01;

public class Solution
{
    /// <summary>
    /// Decrement Each Duplicate Until it is Unique
    /// </summary>
    public int MinDeletions(string s)
    {
        // Store the frequency of each character
        var frequency = new int[26];
        foreach (var c in s)
            frequency[c - 'a']++;

        var deleteCount = 0;

        // Use a set to store the frequencies we have already seen
        var seenFrequencies = new HashSet<int>();
        for (var i = 0; i < 26; i++)
        {
            // Keep decrementing the frequency until it is unique
            while (frequency[i] > 0 && seenFrequencies.Contains(frequency[i]))
            {
                frequency[i]--;
                deleteCount++;
            }

            // Add the newly occupied frequency to the set
            seenFrequencies.Add(frequency[i]);
        }

        return deleteCount;
    }
}
