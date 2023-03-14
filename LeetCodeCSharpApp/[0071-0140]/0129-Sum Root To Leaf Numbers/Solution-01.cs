using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SumRootToLeafNumbers01;

public class Solution
{
    public int SumNumbers(TreeNode root) => Dfs(root, 0);

    private static int Dfs(TreeNode node, int currNum)
    {
        if (node == null)
            return 0;

        currNum = currNum * 10 + node.val;

        if (node.left == null && node.right == null)
            return currNum;

        return Dfs(node.left!, currNum) + Dfs(node.right, currNum);
    }
}
