// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.CountOfInterestingSubarrays01;

public class Solution
{
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k)
    {
        var result = 0L;
        var sum = 0;
        var map = new Dictionary<int, int> { [0] = 1 };

        foreach (var a in nums)
        {
            sum = (sum + (a % modulo == k ? 1 : 0)) % modulo;

            result += map.ContainsKey((sum - k + modulo) % modulo)
                ? map[(sum - k + modulo) % modulo]
                : 0;

            if (map.ContainsKey(sum))
                map[sum]++;
            else
                map[sum] = 1;
        }

        return result;
    }
}
