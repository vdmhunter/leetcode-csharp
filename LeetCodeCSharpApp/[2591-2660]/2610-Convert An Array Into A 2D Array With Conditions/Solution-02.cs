namespace LeetCodeCSharpApp.ConvertAnArrayIntoA2DArrayWithConditions02;

public class Solution
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        var result = new List<IList<int>>();
        var n = nums.Length;
        var count = new int[n + 1];

        foreach (var num in nums)
        {
            if (result.Count <= count[num])
                result.Add(new List<int>());

            result[count[num]++].Add(num);
        }

        return result;
    }
}
