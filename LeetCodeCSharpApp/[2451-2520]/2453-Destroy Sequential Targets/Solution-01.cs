namespace LeetCodeCSharpApp.DestroySequentialTargets01;

// All elements in the sequence have the same modulo of space.
// Count elements with the same modulo, and return the smallest element with the highest frequency modulo.

public class Solution
{
    public int DestroyTargets(int[] nums, int space)
    {
        var dic = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (dic.ContainsKey(n % space))
                dic[n % space]++;
            else
                dic.Add(n % space, 1);
        }

        return nums.Max(Comparer<int>.Create((x, y) =>
        {
            int c1 = dic[x % space], c2 = dic[y % space];

            if (c1 == c2)
                return x > y ? -1 : x < y ? 1 : 0;

            return c1 > c2 ? 1 : c1 < c2 ? -1 : 0;
        }));
    }
}
