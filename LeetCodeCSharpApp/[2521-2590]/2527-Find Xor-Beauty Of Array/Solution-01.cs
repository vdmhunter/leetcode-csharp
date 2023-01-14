namespace LeetCodeCSharpApp.FindXorBeautyOfArray01;

public class Solution
{
    public int XorBeauty(int[] nums)
    {
        return nums.Aggregate(0, (current, x) => current ^ x);
    }
}
