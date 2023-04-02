namespace LeetCodeCSharpApp.MiceAndCheese02;

public class Solution
{
    public int MiceAndCheese(int[] reward1, int[] reward2, int k)
    {
        return reward2.Sum() + (from p in reward1.Zip(reward2, (a, b) => a - b) orderby p descending select p).Take(k).Sum();
    }
}
