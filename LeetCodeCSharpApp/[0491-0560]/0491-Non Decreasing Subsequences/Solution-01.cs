namespace LeetCodeCSharpApp.NonDecreasingSubsequences01;

public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        var result = new List<IList<int>>();
        Backtrack(nums, 0, new List<int>(), result);

        return result;
    }

    private static void Backtrack(int[] nums, int start, List<int> current, List<IList<int>> result)
    {
        if (current.Count >= 2)
            result.Add(new List<int>(current));

        var used = new HashSet<int>();

        for (var i = start; i < nums.Length; i++)
        {
            if (used.Contains(nums[i]))
                continue;

            if (current.Count != 0 && nums[i] < current[^1])
                continue;

            used.Add(nums[i]);
            current.Add(nums[i]);

            Backtrack(nums, i + 1, current, result);

            current.RemoveAt(current.Count - 1);
        }
    }
}
