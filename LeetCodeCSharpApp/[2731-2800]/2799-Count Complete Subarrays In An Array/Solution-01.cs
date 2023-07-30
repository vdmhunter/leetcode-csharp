namespace LeetCodeCSharpApp.CountCompleteSubarraysInAnArray01;

public class Solution
{
    public int CountCompleteSubarrays(int[] nums)
    {
        int n = nums.Length, k = new HashSet<int>(nums).Count, i = 0;
        var count = new Dictionary<int, int>();
        var result = 0;

        for (var j = 0; j < n; j++)
        {
            if (!count.ContainsKey(nums[j]))
                count[nums[j]] = 0;

            count[nums[j]]++;

            while (count.Count == k)
            {
                count[nums[i]]--;

                if (count[nums[i]] == 0)
                    count.Remove(nums[i]);

                i++;
            }

            result += i;
        }

        return result;
    }
}
