namespace LeetCodeCSharpApp.MinimumOneBitOperationsToMakeIntegersZero01;

public class Solution
{
    public int MinimumOneBitOperations(int n)
    {
        var result = 0;

        while (n != 0)
        {
            var b = 1;

            while (b << 1 <= n)
                b <<= 1;

            n = (b >> 1) ^ b ^ n;
            result += b;
        }

        return result;
    }
}
