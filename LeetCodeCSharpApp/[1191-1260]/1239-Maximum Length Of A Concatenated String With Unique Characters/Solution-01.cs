using System.Numerics;

namespace LeetCodeCSharpApp.MaximumLengthOfAConcatenatedStringWithUniqueCharacters;

public class Solution
{
    public int MaxLength(IList<string> arr)
    {
        var dp = new List<int> { 0 };
        var result = 0;
        
        foreach (var s in arr)
        {
            int a = 0, dup = 0;
            
            foreach (var c in s)
            {
                dup |= a & (1 << (c - 'a'));
                a |= 1 << (c - 'a');
            }

            if (dup > 0)
                continue;
            
            for (var i = dp.Count - 1; i >= 0; --i)
            {
                if ((dp[i] & a) > 0)
                    continue;
                
                dp.Add(dp[i] | a);
                
                result = Math.Max(result, BitOperations.PopCount((uint)(dp[i] | a)));
            }
        }

        return result;
    }
}
