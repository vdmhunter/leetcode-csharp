namespace LeetCodeCSharpApp.DivideArrayIntoArraysWithMaxDifference01;

public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);

        var result = Enumerable.Range(0, nums.Length / 3)
            .Select(i => nums.Skip(i * 3).Take(3).ToArray())
            .TakeWhile(group => group[2] - group[0] <= k)
            .ToArray();

        return result.Length < nums.Length / 3
            ? Array.Empty<int[]>()
            : result;
    }
}
