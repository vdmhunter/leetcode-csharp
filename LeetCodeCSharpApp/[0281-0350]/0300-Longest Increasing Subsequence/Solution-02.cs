namespace LeetCodeCSharpApp.LongestIncreasingSubsequence02;

/// <summary>
/// Greedy with Binary Search
/// </summary>
public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var sub = new List<int>();
        
        foreach (var x in nums)
            if (sub.Count == 0 || sub[^1] < x)
                sub.Add(x);
            else
            {
                // Find the index of the smallest number >= x
                // var idx = Enumerable.Range(0, sub.Count).FirstOrDefault(i => sub[i] >= x);
                
                var i = sub.BinarySearch(x);
                var idx = i < 0 ? ~i : i;
                sub[idx] = x;
            }

        return sub.Count;
    }
}
