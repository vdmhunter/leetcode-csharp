namespace LeetCodeCSharpApp.MiceAndCheese02;

public class Solution
{
    public int MiceAndCheese(int[] reward1, int[] reward2, int k)
    {
        return reward2.Sum() + reward1.Zip(reward2, (a, b) => a - b).OrderByDescending(p => p).Take(k).Sum();
    }
}
