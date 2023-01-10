using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SameTree02;

/// <summary>
/// Iteration
/// </summary>
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        var queue = new LinkedList<TreeNode>();
        queue.AddFirst(p);
        queue.AddFirst(q);

        while (queue.Count != 0)
        {
            p = queue.First!.Value;
            queue.RemoveFirst();
            q = queue.First!.Value;
            queue.RemoveFirst();

            if (p == null! && q == null!)
                continue;

            if (p == null! || q == null!)
                return false;

            if (p.val != q.val)
                return false;

            queue.AddFirst(p.left);
            queue.AddFirst(q.left);
            queue.AddFirst(p.right);
            queue.AddFirst(q.right);
        }

        return true;
    }
}
