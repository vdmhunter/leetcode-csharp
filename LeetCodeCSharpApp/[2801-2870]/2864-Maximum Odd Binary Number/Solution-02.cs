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

        return new string('1', onesCnt - 1) + new string('0', n - onesCnt) + new string('1', 1);
    }
}
