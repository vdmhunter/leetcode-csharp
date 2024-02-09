namespace LeetCodeCSharpApp.LargestDivisibleSubset01;

public class Solution
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        if (nums.Length == 0)
            return new List<int>();

        Array.Sort(nums);

        var ds = nums.Select(num => new List<int> { num }).ToList();

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] != 0 || ds[i].Count >= ds[j].Count + 1)
                    continue;

                ds[i] = [..ds[j], nums[i]];
            }
        }

        return ds.OrderByDescending(s => s.Count).First();
    }
}
