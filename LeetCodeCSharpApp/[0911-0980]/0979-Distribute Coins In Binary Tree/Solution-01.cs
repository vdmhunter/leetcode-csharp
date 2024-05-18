using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.DistributeCoinsInBinaryTree01;

public class Solution
{
    private int _moves;

    public int DistributeCoins(TreeNode root)
    {
        Dfs(root);

        return _moves;
    }

    private int Dfs(TreeNode node)
    {
        if (node == null!)
            return 0;

        int leftExcess = Dfs(node.left);
        int rightExcess = Dfs(node.right);
        _moves += Math.Abs(leftExcess) + Math.Abs(rightExcess);

        return node.val + leftExcess + rightExcess - 1;
    }
}
