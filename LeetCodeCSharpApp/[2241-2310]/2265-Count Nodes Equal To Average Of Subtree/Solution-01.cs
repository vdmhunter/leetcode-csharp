using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CountNodesEqualToAverageOfSubtree01;

public class Solution
{
    public int AverageOfSubtree(TreeNode root)
    {
        var result = 0;
        Traverse(root, ref result);

        return result;
    }

    private (int, int) Traverse(TreeNode node, ref int result)
    {
        if (node == null!)
            return (0, 0);

        var (leftSum, leftCount) = Traverse(node.left, ref result);
        var (rightSum, rightCount) = Traverse(node.right, ref result);

        var currSum = node.val + leftSum + rightSum;
        var currCount = 1 + leftCount + rightCount;

        if (currSum / currCount == node.val)
            result++;

        return (currSum, currCount);
    }
}
