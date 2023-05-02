namespace LeetCodeCSharpApp.SignOfTheProductOfAnArray02;

public class Solution
{
    public int ArraySign(int[] nums)
    {
        if (nums.Any(num => num == 0))
            return 0;

        return nums.Count(num => num < 0) % 2 == 0 ? 1 : -1;
    }
}
