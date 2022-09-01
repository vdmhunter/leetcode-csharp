using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CountGoodNodesInBinaryTree01;

public class Solution
{
    public int GoodNodes(TreeNode root, int max = int.MinValue)
    {
        return root == null
            ? 0
            : (root.val >= max ? 1 : 0)
              + GoodNodes(root.left, Math.Max(max, root.val))
              + GoodNodes(root.right, Math.Max(max, root.val));
    }
}
