namespace LeetCodeCSharpApp.DiagonalTraverseII02;

public class Solution
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        return Enumerable.Range(0, nums.Count)
            .SelectMany(r => Enumerable.Range(0, nums[r].Count)
                .Select(c => (Index: r + c, Value: nums[r][c])))
            .GroupBy(x => x.Index, x => x.Value)
            .OrderBy(group => group.Key)
            .SelectMany(group => group.Reverse())
            .ToArray();
    }
}
