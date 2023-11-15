namespace LeetCodeCSharpApp.MaximumStrongPairXOR_II01;

public class Solution
{
    public int MaximumStrongPairXor(int[] nums)
    {
        var result = 0;

        for (var i = 20; i >= 0; i--)
        {
            result <<= 1;
            Dictionary<int, int> pref = new(), pref2 = new();

            foreach (var a in nums)
            {
                var p = a >> i;

                if (!pref.ContainsKey(p))
                {
                    pref[p] = a;
                    pref2[p] = a;
                }

                pref[p] = Math.Min(pref[p], a);
                pref2[p] = Math.Max(pref2[p], a);
            }

            var tmp = result;

            var validPairs = from x in pref.Keys
                let y = tmp ^ 1 ^ x
                where x >= y && pref.ContainsKey(y) && pref[x] <= pref2[y] * 2
                select x;

            if (validPairs.Any())
                result |= 1;
        }

        return result;
    }
}

