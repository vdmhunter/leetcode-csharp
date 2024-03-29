using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MinimumNumberOfOperationsToSortABinaryTreeByLevel01;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public int MinimumOperations(TreeNode root)
    {
        var result = 0;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count != 0)
        {
            var size = q.Count;
            var list = new List<int>();

            while (size-- > 0)
            {
                var node = q.Dequeue();

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                    list.Add(node.left.val);
                }

                if (node.right == null)
                    continue;

                q.Enqueue(node.right);
                list.Add(node.right.val);
            }

            result += Helper(list);
        }

        return result;
    }

    private int Helper(List<int> list)
    {
        var swaps = 0;
        var sorted = new int[list.Count];

        for (var i = 0; i < sorted.Length; i++)
            sorted[i] = list[i];

        Array.Sort(sorted);

        var ind = new Dictionary<int, int>();

        for (var i = 0; i < list.Count; i++)
            ind[list[i]] = i;

        for (var i = 0; i < list.Count; i++)
            if (list[i] != sorted[i])
            {
                swaps++;
                ind[list[i]] = ind[sorted[i]];
                list[ind[sorted[i]]] = list[i];
            }

        return swaps;
    }
}
