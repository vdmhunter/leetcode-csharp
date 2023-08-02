namespace LeetCodeCSharpApp.Combinations02;

public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var result = new List<IList<int>>();
        var nums = new int[n];

        for (var i = 0; i < n; i++)
            nums[i] = i + 1;

        Backtrack(nums, result, new List<int>(), k, 0);

        return result;
    }

    private static void Backtrack(int[] nums, IList<IList<int>> result, IList<int> tempList, int k, int start)
    {
        if (tempList.Count == k)
        {
            result.Add(new List<int>(tempList));

            return;
        }

        for (var i = start; i < nums.Length; i++)
        {
            tempList.Add(nums[i]);
            Backtrack(nums, result, tempList, k, i + 1);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}
