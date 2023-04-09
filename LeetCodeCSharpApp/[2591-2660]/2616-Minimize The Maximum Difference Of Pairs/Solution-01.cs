namespace LeetCodeCSharpApp.MinimizeTheMaximumDifferenceOfPairs01;

public class Solution
{
    public int MinimizeMax(int[] nums, int p)
    {
        Array.Sort(nums);
        int n = nums.Length, left = 0, right = nums[n - 1] - nums[0];

        while (left < right)
        {
            int mid = (left + right) / 2, k = 0;

            for (var i = 1; i < n && k < p; ++i)
            {
                if (nums[i] - nums[i - 1] > mid)
                    continue;

                k++;
                i++;
            }

            if (k >= p)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}
