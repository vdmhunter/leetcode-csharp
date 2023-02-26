namespace LeetCodeCSharpApp.EditDistance01;

public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        var m = word1.Length;
        var n = word2.Length;

        var distance = new int[m + 1, n + 1];

        for (var i = 0; i <= m; i++)
            distance[i, 0] = i;

        for (var j = 0; j <= n; j++)
            distance[0, j] = j;

        for (var i = 1; i <= m; i++)
            for (var j = 1; j <= n; j++)
            {
                distance[i, j] = distance[i - 1, j - 1];

                if (word1[i - 1] != word2[j - 1])
                    distance[i, j] = Math.Min(distance[i, j], Math.Min(distance[i - 1, j], distance[i, j - 1])) + 1;
            }

        return distance[m, n];
    }
}
