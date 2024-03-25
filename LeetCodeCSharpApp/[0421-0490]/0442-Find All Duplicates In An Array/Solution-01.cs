namespace LeetCodeCSharpApp.FindAllDuplicatesInAnArray01;

public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var result = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;

            if (nums[index] < 0)
                result.Add(index + 1);

            nums[index] = -nums[index];
        }

        return result;
    }
}
