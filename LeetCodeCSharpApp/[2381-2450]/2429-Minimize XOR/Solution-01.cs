namespace LeetCodeCSharpApp.MinimizeXOR01;

public class Solution
{
    public int MinimizeXor(int num1, int num2)
    {
        int a = CountSetBits(num1), b = CountSetBits(num2), result = num1;

        for (var i = 0; i < 32; ++i)
        {
            if (a > b && ((1 << i) & num1) > 0)
            {
                result ^= 1 << i;
                a--;
            }

            if (a < b && ((1 << i) & num1) == 0)
            {
                result ^= 1 << i;
                a++;
            }
        }

        return result;
    }

    private static int CountSetBits(int n)
    {
        var count = 0;

        while (n > 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }
}
