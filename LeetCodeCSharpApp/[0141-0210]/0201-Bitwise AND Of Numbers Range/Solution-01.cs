namespace LeetCodeCSharpApp.BitwiseANDOfNumbersRange01;

/// <summary>
/// Bit Shift
/// 
/// Time Complexity: O(1)
/// Space Complexity: O(1)
/// </summary>
public class Solution
{
    public int RangeBitwiseAnd(int m, int n)
    {
        var shift = 0;

        while (m < n)
        {
            m >>= 1;
            n >>= 1;
            shift++;
        }

        return m << shift;
    }
}
