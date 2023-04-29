using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LeafSimilarTrees02;

public class Solution
{
    private string _s1 = "";

    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        Helper(root1);

        var temp = _s1;
        _s1 = "";

        Helper(root2);

        return _s1 == temp;
    }

    private void Helper(TreeNode n)
    {
        if (n.left == null && n.right == null)
        {
            _s1 = _s1 + ":" + n.val;
        }
        else
        {
            if (n.left != null)
                Helper(n.left);

            if (n.right != null)
                Helper(n.right);
        }
    }
}
