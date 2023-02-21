namespace LeetCodeCSharpApp.SingleElementInASortedArray01;

public class Solution
{
    public int SingleNonDuplicate(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l < r)
        {
            var m = l + (r - l) / 2;

            if (m % 2 == 0)
                if (nums[m] == nums[m + 1])
                    l = m + 2;
                else
                    r = m;
            else if (nums[m] == nums[m - 1])
                l = m + 1;
            else
                r = m - 1;
        }

        return nums[l];
    }
}
