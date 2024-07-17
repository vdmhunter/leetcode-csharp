// ReSharper disable InconsistentNaming

using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.DeleteNodesAndReturnForest01;

public class Solution
{
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
    {
        var result = new List<TreeNode>();
        HashSet<int> toDelete = to_delete.ToHashSet();
        DelNodesDfs(ref root, true);

        return result;

        #region DelNodesDfs

        void DelNodesDfs(ref TreeNode node, bool isRoot)
        {
            if (node == null!)
                return;

            bool deleted = toDelete.Contains(node.val);

            DelNodesDfs(ref node.left, deleted);
            DelNodesDfs(ref node.right, deleted);

            if (deleted)
                node = null!;
            else if (isRoot)
                result.Add(node);
        }

        #endregion
    }
}
