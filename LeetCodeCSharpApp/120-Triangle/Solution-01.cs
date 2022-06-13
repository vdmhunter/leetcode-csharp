namespace LeetCodeCSharpApp.Triangle01;

public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        var dp = new int[triangle.Count][];

        using var it = triangle.GetEnumerator();
        it.MoveNext();
        
        dp[0] = new []{ it.Current[0] };

        for(var i = 1; i < triangle.Count; ++i)
        {
            dp[i] = new int[i+1];
            
            it.MoveNext();

            using var it2 = it.Current.GetEnumerator();
            it2.MoveNext();
            
            dp[i][0] = dp[i-1][0] + it2.Current;
            
            for(var j = 1; j < i; ++j)
            {
                it2.MoveNext();
                dp[i][j] = Math.Min(dp[i-1][j-1], dp[i-1][j]) + it2.Current;
            }
            
            it2.MoveNext();
            dp[i][i] = dp[i-1][i-1] + it2.Current;
        }

        return dp[triangle.Count - 1].Prepend(int.MaxValue).Min();
    }
}
