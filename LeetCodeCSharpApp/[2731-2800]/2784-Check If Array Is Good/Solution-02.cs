namespace LeetCodeCSharpApp.CheckIfArrayIsGood02;

public class Solution
{
    public bool IsGood(int[] nums)
    {
        var counts = new int[201];
        var n = nums.Length - 1;

        foreach (var num in nums)
            counts[num]++;

        for (var i = 1; i < n; i++)
            if (counts[i] != 1)
                return false;

        return counts[n] == 2;
    }
}
