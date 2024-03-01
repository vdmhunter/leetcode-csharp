using System.Text;

namespace LeetCodeCSharpApp.MaximumOddBinaryNumber02;

/// <summary>
///   Greedy Bit Manipulation (Counting Ones)
/// 
///   Time Complexity: O(N)
///   Space Complexity: O(N)
/// </summary>
public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        int n = s.Length;
        int onesCnt = s.Sum(c => c - '0');

        var sb = new StringBuilder();

        for (var i = 0; i < onesCnt - 1; i++)
            sb.Append('1');

        for (var i = 0; i < n - onesCnt; i++)
            sb.Append('0');

        sb.Append('1');

        return sb.ToString();
    }
}
