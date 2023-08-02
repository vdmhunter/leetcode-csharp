namespace LeetCodeCSharpApp.Permutations02;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        Dfs(nums, new List<int>(), result);

        return result;
    }

    private static void Dfs(int[] nums, IList<int> path, IList<IList<int>> result)
    {
        if (nums.Length == 0)
        {
            result.Add(new List<int>(path));

            return;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var newNums = new List<int>(nums);
            newNums.RemoveAt(i);

            path.Add(nums[i]);
            Dfs(newNums.ToArray(), path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}
