namespace LeetCodeCSharpApp.MatchsticksToSquare01;

public class Solution
{
    public bool Makesquare(int[] matchsticks)
    {
        var total = matchsticks.Sum();

        // if we cant make 4 equals sides then theres no way to make a square
        if (total % 4 != 0)
            return false;

        // sort the array and place the largest sides first. required optimization to not TLE
        Array.Sort(matchsticks);

        return Match(matchsticks, matchsticks.Length - 1, 0, 0, 0, 0, total / 4);
    }

    private static bool Match(IReadOnlyList<int> matchsticks, int index, int top, int bottom, int left, int right,
        int target)
    {
        if (top == target && bottom == target && left == target && right == target)
            return true;

        if (top > target || bottom > target || left > target || right > target)
            return false;

        var val = matchsticks[index];

        // Top
        if (Match(matchsticks, index - 1, top + val, bottom, left, right, target))
            return true;

        // Bottom
        if (Match(matchsticks, index - 1, top, bottom + val, left, right, target))
            return true;

        // Left
        if (Match(matchsticks, index - 1, top, bottom, left + val, right, target))
            return true;

        // Right
        if (Match(matchsticks, index - 1, top, bottom, left, right + val, target))
            return true;

        return false;
    }
}
