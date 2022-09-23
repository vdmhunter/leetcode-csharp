namespace LeetCodeCSharpApp.ConcatenationOfConsecutiveBinaryNumbers02;

public class Solution
{
    /// <summary>
    /// Bit Manipulation
    /// </summary>
    public int ConcatenatedBinary(int n)
    {
        var result = 0L;
        var mod = 1000000007L;

        for (var i = 1; i <= n; i++)
        {
            var binary = Convert.ToString(i, 2);
            result = (result << binary.Length) % mod;
            result = (result + i) % mod;
        }

        return (int)result;
    }
}
