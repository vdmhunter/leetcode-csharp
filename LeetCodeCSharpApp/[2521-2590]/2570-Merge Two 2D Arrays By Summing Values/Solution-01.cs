namespace LeetCodeCSharpApp.MergeTwo2DArraysBySummingValues01;

public class Solution
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        var dict = new Dictionary<int, int>();

        foreach (var nums in new[] { nums1, nums2 })
            foreach (var pair in nums)
            {
                if (!dict.ContainsKey(pair[0]))
                    dict[pair[0]] = 0;

                dict[pair[0]] += pair[1];
            }

        var result = new int[dict.Count][];
        var i = 0;

        foreach (var pair in dict.OrderBy(p => p.Key))
        {
            result[i] = new[] { pair.Key, pair.Value };
            i++;
        }

        return result;
    }
}
