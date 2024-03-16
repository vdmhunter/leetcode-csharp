namespace LeetCodeCSharpApp.ContiguousArray01;

public class Solution
{
    public int FindMaxLength(int[] nums)
    {
        var count = 0;
        var result = 0;
        var table = new Dictionary<int, int> { { 0, 0 } };

        for (var index = 0; index < nums.Length; index++)
        {
            if (nums[index] == 0)
                count -= 1;
            else
                count += 1;

            if (table.TryGetValue(count, out int value))
                result = Math.Max(result, index + 1 - value);
            else
                table[count] = index + 1;
        }

        return result;
    }
}
