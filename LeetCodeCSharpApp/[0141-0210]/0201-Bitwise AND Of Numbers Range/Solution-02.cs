namespace LeetCodeCSharpApp.BitwiseANDOfNumbersRange02;

/// <summary>
/// Brian Kernighan's Algorithm
/// 
/// Time Complexity: O(1)
/// Space Complexity: O(1)
/// </summary>
public class Solution
{
    public int RangeBitwiseAnd(int m, int n)
    {
        while (m < n)
            n &= n - 1;

        return m & n;
    }
}
