using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.InvertBinaryTree01;

public class Solution 
{
    public TreeNode InvertTree(TreeNode root) 
    {
        if (root == null)
            return root!;
        
        var temp = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(temp);

        return root;
    }
}
