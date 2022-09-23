namespace LeetCodeCSharpApp.ConcatenationOfConsecutiveBinaryNumbers01;

public class Solution
{
    /// <summary>
    /// Simple Loop
    /// </summary>
    public int ConcatenatedBinary(int n)
    {
        var result = 0L;
        var m = 2L;
        const long mod = 1000000007L;

        for (var i = 1; i <= n; i++)
        {
            if (i == m)
                m *= 2;

            result = (result * m + i) % mod;
        }
        
        return (int)result;
    }
}
