namespace LeetCodeCSharpApp.ApplyOperationsToMakeAllArray_ElementsEqualToZero01;

public class Solution
{
    public bool CheckArray(int[] nums, int k)
    {
        var n = nums.Length;
        var diff = new int[n];
        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            if (i >= k)
                sum -= diff[i - k];

            var change = nums[i] - sum;

            if (change < 0)
                return false;

            diff[i] = change;
            sum += change;
        }

        for (var i = n - k + 1; i < n; i++)
        {
            sum -= diff[i - 1];

            if (sum != 0)
                return false;
        }

        return true;
    }
}

