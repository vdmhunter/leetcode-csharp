namespace LeetCodeCSharpApp.CheckIfArrayIsGood01;

public class Solution
{
    public bool IsGood(int[] nums)
    {
        var n = nums.Length;
        var max = 0;

        for (var i = 0; i < n; i++)
            max = Math.Max(max, nums[i]);

        if (n != max + 1)
            return false;

        var count = new int[max + 1];

        for (var i = 0; i < n; i++)
            count[nums[i]]++;

        for (var i = 1; i < max; i++)
            if (count[i] != 1)
                return false;
        
        return count[max] == 2;
    }
}
