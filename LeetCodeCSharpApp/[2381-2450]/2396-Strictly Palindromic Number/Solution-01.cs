namespace LeetCodeCSharpApp.StrictlyPalindromicNumber01;

public class Solution
{
    public bool IsStrictlyPalindromic(int n)
    {
        for (var i = 2; i <= n - 2; i++)
        {
            var arr = DecimalToArbitrarySystem(n, i).ToArray();

            if (!arr.SequenceEqual(arr.Reverse()))
                return false;
        }

        return true;
    }

    private static List<int> DecimalToArbitrarySystem(int number, int radix)
    {
        if (number == 0)
            return new List<int> { 0 };

        var result = new List<int>();

        while (number != 0)
        {
            var remainder = number % radix;
            result.Add(remainder);
            number /= radix;
        }

        return result;
    }
}
