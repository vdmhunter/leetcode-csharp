namespace LeetCodeCSharpApp.DiagonalTraverseII01;

public class Solution
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        var map = new Dictionary<int, List<int>>();
        var maxKey = 0;

        for (var r = nums.Count - 1; r >= 0; r--)
        {
            for (var c = 0; c < nums[r].Count; c++)
            {
                if (!map.TryGetValue(r + c, out var list))
                {
                    list = new List<int>();
                    map[r + c] = list;
                }

                list.Add(nums[r][c]);
                maxKey = Math.Max(maxKey, r + c);
            }
        }

        return FlattenDictionaryIntoArray(map, maxKey);
    }

    private static int[] FlattenDictionaryIntoArray(IReadOnlyDictionary<int, List<int>> map, int maxKey)
    {
        var result = new int[map.Sum(kvp => kvp.Value.Count)];
        var index = 0;

        for (var key = 0; key <= maxKey; key++)
            if (map.TryGetValue(key, out var value))
                foreach (var v in value)
                    result[index++] = v;

        return result;
    }
}
