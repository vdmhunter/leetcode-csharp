namespace LeetCodeCSharpApp.MinimumOperationsToReduceXtoZero01;

public class Solution
{
    public int MinOperations(int[] nums, int x)
    {
        var minStep = int.MaxValue;

        var sum = nums.Sum();

        //sum of the required subarray
        var target = sum - x;

        switch (target)
        {
            //if all the elements has to be selected
            case 0:
                return nums.Length;
            //if even selecting all the elements aren't enough
            case < 0:
                return -1;
        }

        //to track the subarray/sliding window
        int l = 0, r = 0;

        //sum of the sliding window
        var ps = nums[r];
        do
        {
            if (ps >= target)
            {
                //if current subarray/window sum matches the target
                //we update the ans, and continue to search the largest window
                if (ps == target)
                    minStep = Math.Min(minStep, nums.Length - (r - l + 1));

                ps -= nums[l];
                l++;
            }
            else
            {
                r++;

                if (r < nums.Length)
                    ps += nums[r];
            }
        } while (l < nums.Length && r < nums.Length);

        return minStep != int.MaxValue ? minStep : -1;
    }
}
