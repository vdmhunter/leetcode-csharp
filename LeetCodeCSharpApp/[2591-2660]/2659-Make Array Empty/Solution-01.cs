namespace LeetCodeCSharpApp.MakeArrayEmpty01;

public class Solution
{
    public long CountOperationsToEmptyArray(int[] nums)
    {
        var n = nums.Length;
        var idx = Enumerable.Range(0, n).ToArray();

        Array.Sort(idx, (x, y) => nums[x].CompareTo(nums[y]));
        var m = n;
        var result = 0L;

        for (int i = 1, last = 0; i < n; ++i)
            if (idx[i] < idx[i - 1])
            {
                result += m;
                m -= i - last;
                last = i;
            }

        result += m;

        return result;
    }
}
