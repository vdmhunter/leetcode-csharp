namespace LeetCodeCSharpApp.CountElementsWithMaximumFrequency03;

/// <summary>
///   One-Pass Sum Max Frequencies
///
///   Time complexity: O(N)
///   Space complexity: O(N)
/// </summary>
public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        var frequencies = new Dictionary<int, int>();
        var maxFrequency = 0;
        var totalFrequencies = 0;

        foreach (int num in nums)
        {
            if (frequencies.TryGetValue(num, out int value))
                frequencies[num] = ++value;
            else
                frequencies[num] = 1;

            int frequency = frequencies[num];

            if (frequency > maxFrequency)
            {
                maxFrequency = frequency;
                totalFrequencies = frequency;
            }
            else if (frequency == maxFrequency)
            {
                totalFrequencies += frequency;
            }
        }

        return totalFrequencies;
    }
}
