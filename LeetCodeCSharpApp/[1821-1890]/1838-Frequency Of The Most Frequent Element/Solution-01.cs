namespace LeetCodeCSharpApp.FrequencyOfTheMostFrequentElement01;

public class Solution
{
    public int MaxFrequency(int[] nums, long k)
    {
        int i = 0, j;

        Array.Sort(nums);

        for (j = 0; j < nums.Length; j++)
        {
            k += nums[j];

            if (k < (long)nums[j] * (j - i + 1))
                k -= nums[i++];
        }

        return j - i;
    }
}
