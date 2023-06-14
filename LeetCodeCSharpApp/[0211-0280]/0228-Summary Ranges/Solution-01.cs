namespace LeetCodeCSharpApp.SummaryRanges01;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var result = new List<string>();

        for (var i = 0; i < nums.Length; i++)
        {
            var start = nums[i];

            while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
                i++;

            if (start != nums[i])
                result.Add("" + start + "->" + nums[i]);
            else
                result.Add("" + start);
        }

        return result;
    }
}
