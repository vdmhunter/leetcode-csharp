// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract

using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreeLevelOrderTraversal01;

/// <summary>
/// Solution with a queue
/// </summary>
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        var q = new Queue<TreeNode>();

        if (root != null)
            q.Enqueue(root);

        while (q.Count != 0)
        {
            var levelSize = q.Count;
            var level = new List<int>(levelSize);
            
            for (var i = 0; i < levelSize; i++)
            {
                var cur = q.Dequeue();
                
                if (cur.left != null)
                    q.Enqueue(cur.left);
                
                if (cur.right != null)
                    q.Enqueue(cur.right);
                
                level.Add(cur.val);
            }

            res.Add(level);
        }

        return res;
    }
}
