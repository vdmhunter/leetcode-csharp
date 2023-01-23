namespace LeetCodeCSharpApp.FindTheTownJudge01;

public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        var count = new int[n + 1];

        foreach (var t in trust)
        {
            count[t[0]]--;
            count[t[1]]++;
        }

        for (var i = 1; i < count.Length; i++)
            if (count[i] == n - 1)
                return i;

        return -1;
    }
}
