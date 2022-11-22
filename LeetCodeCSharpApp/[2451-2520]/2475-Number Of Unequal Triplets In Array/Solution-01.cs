namespace LeetCodeCSharpApp.NumberOfUnequalTripletsInArray01;

public class Solution
{
    public int UnequalTriplets(int[] nums)
    {
        var m = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (m.ContainsKey(n))
                m[n]++;
            else
                m.Add(n, 1);
        }

        int result = 0, left = 0, right = nums.Length;

        foreach (var (_, cnt) in m)
        {
            right -= cnt;
            result += left * cnt * right;
            left += cnt;
        }

        return result;
    }
}
