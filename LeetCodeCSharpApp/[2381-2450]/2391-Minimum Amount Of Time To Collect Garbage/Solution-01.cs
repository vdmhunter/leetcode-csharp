namespace LeetCodeCSharpApp.MinimumAmountOfTimeToCollectGarbage01;

public class Solution
{
    public int GarbageCollection(string[] garbage, int[] travel)
    {
        var result = 0;
        var last = new int[128];

        for (var i = 0; i < garbage.Length; i++)
        {
            result += garbage[i].Length;

            for (var j = 0; j < garbage[i].Length; j++)
                last[garbage[i][j]] = i;
        }

        for (var i = 1; i < travel.Length; i++)
            travel[i] += travel[i - 1];

        result += "PGM".Where(c => last[c] > 0).Sum(c => travel[last[c] - 1]);

        return result;
    }
}
