namespace LeetCodeCSharpApp.Permutations01;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        return nums.Aggregate(
            seed: new List<IList<int>> { new List<int>() },
            func: (result, n) => result.SelectMany(
                perm => Enumerable.Range(0, perm.Count + 1)
                    .Select(i => perm.Take(i).Concat(new[] { n }).Concat(perm.Skip(i)).ToList())).ToList<IList<int>>()
        );
    }
}
