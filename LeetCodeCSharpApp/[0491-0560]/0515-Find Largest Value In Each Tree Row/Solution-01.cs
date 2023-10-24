using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.FindLargestValueInEachTreeRow01;

public class Solution
{
    public IList<int> LargestValues(TreeNode root)
    {
        var result = new List<int>();
        Helper(root, result, 0);

        return result;
    }

    private static void Helper(TreeNode root, List<int> result, int d)
    {
        if (root == null!)
            return;

        if (d == result.Count)
            result.Add(root.val);
        else
            result[d] = Math.Max(result[d], root.val);

        Helper(root.left, result, d + 1);
        Helper(root.right, result, d + 1);
    }
}
