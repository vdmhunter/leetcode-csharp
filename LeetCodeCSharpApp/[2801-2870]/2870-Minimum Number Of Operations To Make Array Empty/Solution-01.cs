namespace LeetCodeCSharpApp.MinimumNumberOfOperationsToMakeArrayEmpty01;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var cnt = nums.GroupBy(x => x).Select(g => g.Count()).ToArray();

        return cnt.Min() == 1 ? -1 : cnt.Sum(c => c / 3 + (c % 3 > 0 ? 1 : 0));
    }
}
