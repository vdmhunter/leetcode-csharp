namespace LeetCodeCSharpApp.NumberOfSubarraysWithLCMEqualToK01;

// For an element i, we count unique lcm values for subarrays [0..i], [1..i], ... [i - 1..i], [i].
// The number of unique lcm values will not exceed the number of divisors of k (d(k)).
    
public class Solution
{
    public int SubarrayLCM(int[] nums, int k)
    {
        var result = 0;
        var dic1 = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            AddOrUpdate(dic1, n, 1);

            var dic2 = new Dictionary<int, int>();

            foreach (var kv in dic1)
            {
                var lcm = kv.Key * n / Gcd(kv.Key, n);
                
                if (lcm == k)
                    result += kv.Value;

                if (k % lcm != 0)
                    continue;
                
                AddOrUpdate(dic2, lcm, kv.Value);
            }

            dic1 = dic2;
        }

        return result;
    }
    
    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
    
    private static void AddOrUpdate(IDictionary<int, int> dictionary, int key, int value)
    {
        if (dictionary.ContainsKey(key))
            dictionary[key] += value;
        else
            dictionary.Add(key, value);
    }
    
    // private static int Lcm(IReadOnlyList<int> arr, int idx)
    // {
    //     if (idx == arr.Count - 1)
    //         return arr[idx];
    //
    //     var a = arr[idx];
    //     var b = Lcm(arr, idx + 1);
    //
    //     return a * b / Gcd(a, b);
    // }
}
