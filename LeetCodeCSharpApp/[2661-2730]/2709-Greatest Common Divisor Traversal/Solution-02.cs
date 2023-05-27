namespace LeetCodeCSharpApp.GreatestCommonDivisorTraversal02;

public class Solution
{
    private static readonly int[] Primes =
    {
        2,   3,   5 ,  7,   11,  13,  17,  19,  23,  29,  31,
        37,  41,  43,  47,  53,  59,  61,  67,  71,  73,  79,
        83,  89,  97,  101, 103, 107, 109, 113, 127, 131, 137,
        139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193,
        197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257,
        263, 269, 271, 277, 281, 283, 293, 307, 311, 313
    };

    public bool CanTraverseAllPairs(int[] nums)
    {
        var n = nums.Length;
        var ds = Enumerable.Repeat(-1, n).ToArray();
        var map = new Dictionary<int, int>();

        for (var i = 0; i < n; ++i)
        {
            var factors = GetFactors(nums, i);

            foreach (var f in factors)
                Union(f, i, map, ds);
        }

        return Math.Abs(ds.Min()) == n;
    }

    private static List<int> GetFactors(int[] nums, int i)
    {
        var result = new List<int>();

        foreach (var p in Primes)
            if (nums[i] % p == 0)
            {
                result.Add(p);

                while (nums[i] % p == 0)
                    nums[i] /= p;
            }

        if (nums[i] != 1)
            result.Add(nums[i]);

        return result;
    }

    private static void Union(int f, int i, Dictionary<int, int> map, int[] ds)
    {
        if (map.TryGetValue(f, out var value))
        {
            var pi = Find(i, ds);
            var pj = Find(value, ds);

            if (pi == pj)
                return;

            if (ds[pi] > ds[pj])
                (pi, pj) = (pj, pi);

            ds[pi] += ds[pj];
            ds[pj] = pi;
        }
        else
            map[f] = i;
    }

    private static int Find(int i, int[] ds)
    {
        return ds[i] < 0 ? i : ds[i] = Find(ds[i], ds);
    }
}
