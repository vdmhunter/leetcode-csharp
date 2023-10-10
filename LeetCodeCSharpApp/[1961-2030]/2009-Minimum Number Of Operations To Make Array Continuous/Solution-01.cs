namespace LeetCodeCSharpApp.MinimumNumberOfOperationsToMakeArrayContinuous01;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        Array.Sort(nums);
        var hs = new HashSet<int>(nums).ToArray();
        var len = nums.Length;
        var result = len - 1;
        var right = 0;

        for (var left = 0; left < hs.Length; left++)
        {
            while (right < hs.Length && hs[right] - hs[left] < len)
                right++;

            var size = right - left;
            var times = len - size;

            result = Math.Min(result, times);
        }

        return result;
    }
}
