namespace LeetCodeCSharpApp.CountTheNumberOfGoodSubarrays01;

public class Solution
{
    public long CountGood(int[] nums, int k)
    {
        var result = 0L;
        Dictionary<int, int> count = new();

        for (int i = 0, j = 0; j < nums.Length; j++)
        {
            var c = count.GetValueOrDefault(nums[j]);
            k -= c++;
            count[nums[j]] = c;

            while (k <= 0)
                k += --count[nums[i++]];

            result += i;
        }

        return result;
    }
}

