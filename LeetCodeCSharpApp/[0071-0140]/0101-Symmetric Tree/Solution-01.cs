using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SymmetricTree01;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        return Dfs(root.left, root.right);
    }

    private static bool Dfs(TreeNode root1, TreeNode root2)
    {
        if (root1 is null && root2 is null)
            return true;

        if (root1?.val != root2?.val)
            return false;

        return Dfs(root1?.left!, root2?.right!) &&
               Dfs(root1?.right!, root2?.left!);
    }
}
