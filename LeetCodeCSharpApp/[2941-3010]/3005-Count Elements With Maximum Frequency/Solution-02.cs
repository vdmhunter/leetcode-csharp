namespace LeetCodeCSharpApp.CountElementsWithMaximumFrequency02;

/// <summary>
///   Sort Frequencies and Sum Max Frequencies

///   Time complexity: O(N + M * log(M))
///   Space complexity: O(M)
/// </summary>
public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        var frequencies = new int[100];

        foreach (int num in nums)
            frequencies[num - 1]++;

        Array.Sort(frequencies);
        int maxFreqIndex = frequencies.Length - 1;
        int totalFrequencies = frequencies[maxFreqIndex];

        while (maxFreqIndex > 0 && frequencies[maxFreqIndex] == frequencies[maxFreqIndex - 1])
        {
            totalFrequencies += frequencies[maxFreqIndex];
            maxFreqIndex--;
        }

        return totalFrequencies;
    }
}
