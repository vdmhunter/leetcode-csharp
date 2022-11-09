using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.HeightOfBinaryTreeAfterSubtreeRemovalQueries01;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 * public int val;
 * public TreeNode left;
 * public TreeNode right;
 * public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 * this.val = val;
 * this.left = left;
 * this.right = right;
 * }
 * }
 */

public class Solution
{
    private readonly int[] _seen = new int[100001];
    private int _maxHeight;

    public int[] TreeQueries(TreeNode root, int[] queries)
    {
        _maxHeight = 0;
        Dfs(root, 0);

        _maxHeight = 0;
        Dfs(root, 0);

        return queries.Select(q => _seen[q]).ToArray();
    }

    private void Dfs(TreeNode root, int h)
    {
        if (root == null)
            return;
        
        _seen[root.val] = Math.Max(_seen[root.val], _maxHeight);
        _maxHeight = Math.Max(_maxHeight, h);
        
        Dfs(root.left, h + 1);
        Dfs(root.right, h + 1);
        
        (root.right, root.left) = (root.left, root.right);
    }
}
