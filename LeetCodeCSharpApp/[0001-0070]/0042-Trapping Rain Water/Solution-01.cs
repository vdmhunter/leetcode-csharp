namespace LeetCodeCSharpApp.TrappingRainWater01;

public class Solution
{
    public int Trap(int[] height)
    {
        int total = 0, high1 = 0, high2 = 0;

        for (int l = 0, r = height.Length - 1; l < r;)
            if (height[l] < height[r])
            {
                high1 = Math.Max(high1, height[l]);
                total += high1 - height[l++];
            }
            else
            {
                high2 = Math.Max(high2, height[r]);
                total += high2 - height[r--];
            }

        return total;
    }
}
