using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.AddOneRowToTree01;

public class Solution
{
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if (depth is 0 or 1)
        {
            var newRoot = new TreeNode(val)
            {
                left = (depth == 1 ? root : null)!,
                right = (depth == 0 ? root : null)!
            };
            
            return newRoot;
        }

        if (root != null! && depth >= 2)
        {
            root.left = AddOneRow(root.left, val, depth > 2 ? depth - 1 : 1);
            root.right = AddOneRow(root.right, val, depth > 2 ? depth - 1 : 0);
        }

        return root!;
    }
}
