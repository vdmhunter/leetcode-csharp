// ReSharper disable InconsistentNaming

using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.AllPossibleFullBinaryTrees01;

public class Solution
{
    private readonly Dictionary<int, IList<TreeNode>> memo = new();

    public IList<TreeNode> AllPossibleFBT(int n)
    {
        if (memo.TryGetValue(n, out var fbt))
            return fbt;

        var list = new List<TreeNode>();

        if (n == 1)
        {
            list.Add(new TreeNode());
        }
        else if (n % 2 == 1)
        {
            for (var i = 0; i < n; ++i)
            {
                var j = n - 1 - i;

                foreach (var left in AllPossibleFBT(i))
                    list.AddRange(AllPossibleFBT(j).Select(right => new TreeNode { left = left, right = right }));
            }
        }

        memo[n] = list;

        return memo[n];
    }
}
