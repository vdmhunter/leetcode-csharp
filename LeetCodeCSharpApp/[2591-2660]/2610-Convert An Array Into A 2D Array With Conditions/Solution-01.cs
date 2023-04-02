namespace LeetCodeCSharpApp.ConvertAnArrayIntoA2DArrayWithConditions01;

public class Solution
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        var result = new List<IList<int>>();
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;

        while (dict.Values.Any(v => v != 0))
        {
            var row = new List<int>();

            foreach (var item in dict.Where(i => i.Value > 0))
            {
                row.Add(item.Key);
                dict[item.Key]--;
            }

            result.Add(row);
        }

        return result;
    }
}
