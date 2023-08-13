namespace LeetCodeCSharpApp.MinimumAbsoluteDifferenceBetweenElementsWithConstraint01;

public class Solution
{
    public int MinAbsoluteDifference(IList<int> nums, int x)
    {
        if (x == 0)
            return 0;

        var list = CreateInitListFromList(nums, x);
        var result = GetResult(list, nums[0]);

        for (var i = 1; i < nums.Count - x; i++)
        {
            list.Remove(nums[i - 1 + x]);
            result = Math.Min(result, GetResult(list, nums[i]));
        }

        return result;
    }

    private static int GetResult(List<int> list, int num)
    {
        var low = 0;

        if (num <= list[low])
            return list[low] - num;

        var high = list.Count - 1;

        if (list[high] < num)
            return num - list[high];

        while (high - low > 1)
        {
            var indexMid = (low + high) / 2;

            if (list[indexMid] < num)
                low = indexMid;
            else
                high = indexMid;
        }

        return Math.Min(num - list[low], list[high] - num);
    }

    private static List<int> CreateInitListFromList(IList<int> nums, int x)
    {
        var result = new List<int>();

        for (var i = x; i < nums.Count; i++)
            result.Add(nums[i]);

        result.Sort();

        return result;
    }
}
