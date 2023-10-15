namespace LeetCodeCSharpApp.NumberOfWaysToStayInTheSamePlaceAfterSomeSteps01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumWays(int steps, int arrLen)
    {
        var maxColumn = Math.Min(arrLen, steps / 2 + 1);
        var curr = new int[maxColumn + 1];
        var prev = new int[maxColumn + 1];
        prev[0] = 1;

        for (var i = 1; i <= steps; i++)
        {
            for (var j = 0; j <= maxColumn; j++)
            {
                curr[j] = prev[j];

                if (j - 1 >= 0)
                    curr[j] = (curr[j] + prev[j - 1]) % Mod;

                if (j + 1 < maxColumn)
                    curr[j] = (curr[j] + prev[j + 1]) % Mod;
            }

            (curr, prev) = (prev, curr);
        }

        return prev[0];
    }
}
