namespace LeetCodeCSharpApp.FrogJump01;

public class Solution
{
    private bool[,] _dp = null!;

    public bool CanCross(int[] stones)
    {
        _dp = new bool[stones.Length, stones.Length];

        return Cross(stones, 0, 0);
    }

    private bool Cross(int[] stones, int k, int index)
    {
        if (_dp[index, k])
            return false;

        if (index == stones.Length - 1)
            return true;

        var i = index;

        while (++i < stones.Length && stones[i] - stones[index] - k < 2)
            if (stones[i] - stones[index] - k > -2)
                if (Cross(stones, stones[i] - stones[index], i))
                    return true;

        _dp[index, k] = true;

        return false;
    }
}
