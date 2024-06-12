namespace LeetCodeCSharpApp.SortColors01;

public class Solution
{
    public void SortColors(int[] nums)
    {
        var zeros = 0;
        var ones = 0;
        int n = nums.Length;

        foreach (int num in nums)
            if (num == 0)
                zeros++;
            else if (num == 1)
                ones++;

        for (var i = 0; i < zeros; i++)
            nums[i] = 0;

        for (int i = zeros; i < zeros + ones; i++)
            nums[i] = 1;

        for (int i = zeros + ones; i < n; i++)
            nums[i] = 2;
    }
}
