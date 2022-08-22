using System.Numerics;

namespace LeetCodeCSharpApp.PowerOfFour02;

// Let's see how we can apply the above function into this problem:
//
// 1. Suppose that x is in the form 4^k
// 2. Then we can change x to 2^(2 * k)
// 3. It is well known in bit manipulation that 2^(2 * k) is equal to 1 << (2 * k)
// 4. That means BitOperations.PopCount(x) == 1 (Since x only has one bit that got left-shifted),
// and BitOperations.TrailingZeroCount(x) % 2 == 0
// (Since the number of trailing zeroes are 2 * k, which is an even number).
// 5. Thus we get the one-liner solution below:

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return BitOperations.PopCount((uint)n) == 1 && BitOperations.TrailingZeroCount((uint)n) % 2 == 0;
    }
}
