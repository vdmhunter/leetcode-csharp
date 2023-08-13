namespace LeetCodeCSharpApp.ApplyOperationsToMaximizeScore01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int MaximumScore(IList<int> nums, int k)
    {
        var result = 1L;
        var remainingCount = (long)k;
        var primeFactorCounts = nums.Select(CountPrimeFactors).ToArray();
        var primeFactorCountRanges = GetPrimeFactorCountRanges(primeFactorCounts, nums);

        primeFactorCountRanges.Sort((a, b) => a[1].CompareTo(b[1]));

        for (var i = primeFactorCountRanges.Count - 1; i >= 0 && remainingCount > 0; i--)
        {
            var currentPair = primeFactorCountRanges[i];
            var min = Math.Min(currentPair[0], remainingCount);
            remainingCount -= min;
            result = result * Power(currentPair[1], min) % Mod;
        }

        return (int)result;
    }

    private static int CountPrimeFactors(int num)
    {
        var count = 0;

        for (var factor = 2; factor * factor <= num; factor++)
        {
            if (num % factor != 0)
                continue;

            count++;

            while (num % factor == 0)
                num /= factor;
        }

        if (num > 1)
            count++;

        return count;
    }

    private static List<long[]> GetPrimeFactorCountRanges(int[] primeFactorCounts, IList<int> nums)
    {
        var n = nums.Count;
        var stack = new Stack<int>();
        var result = new List<long[]>();

        for (var i = 0; i <= n; i++)
        {
            while (stack.Count > 0 && (i == n || primeFactorCounts[stack.Peek()] < primeFactorCounts[i]))
            {
                var poppedIndex = (long)stack.Pop();
                var previousIndex = stack.Count == 0 ? -1L : stack.Peek();
                var primeFactorCount = (poppedIndex - previousIndex) * (i - poppedIndex);

                result.Add(new[] { primeFactorCount, nums[(int)poppedIndex] });
            }

            stack.Push(i);
        }

        return result;
    }

    private static long Power(long a, long b)
    {
        var result = 1L;

        while (b > 0)
        {
            if ((b & 1) > 0)
                result = result * a % Mod;

            a = a * a % Mod;
            b /= 2;
        }

        return result;
    }
}
