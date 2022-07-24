namespace LeetCodeCSharpApp.EqualRowAndColumnPairs01;

public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        var count = 0;
        var n = grid.Length;
        var dic = new Dictionary<string, int>();

        for (var i = 0; i < n; i++)
        {
            var s = string.Empty;
            
            for (var j = 0; j < n; j++)
                s += Convert.ToString(grid[j][i]) + ",";

            if (dic.ContainsKey(s))
                dic[s] += 1;
            else
                dic.Add(s, 1);
        }

        for (var i = 0; i < n; i++)
        {
            var s = string.Join(",", grid[i].Select(j => j.ToString()).ToArray()) + ",";
            count += dic.ContainsKey(s) ? dic[s] : 0;
        }

        return count;
    }
}
