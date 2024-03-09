namespace LeetCodeCSharpApp.CountElementsWithMaximumFrequency01;

/// <summary>
///   Count Frequency and Max Frequency
///
///   Time complexity: O(N)
///   Space complexity: O(N)
/// </summary>
public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        var frequencies = new Dictionary<int, int>();

        foreach (int num in nums)
            if (frequencies.TryGetValue(num, out int value))
                frequencies[num] = ++value;
            else
                frequencies[num] = 1;

        int maxFrequency = frequencies.Values.Prepend(0).Max();
        int frequencyOfMaxFrequency = frequencies.Values.Count(f => f == maxFrequency);

        return frequencyOfMaxFrequency * maxFrequency;
    }
}
