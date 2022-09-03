using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.AverageOfLevelsInBinaryTree01;

/// <summary>
/// BFS
/// </summary>
public class Solution
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var list = new List<double>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count != 0)
        {
            var count = queue.Count;
            double sum = 0;
            
            for (var i = 0; i < count; i++)
            {
                var cur = queue.Dequeue();
                sum += cur.val;
                
                if (cur.left != null)
                    queue.Enqueue(cur.left);
                
                if (cur.right != null)
                    queue.Enqueue(cur.right);
            }

            list.Add(sum / count);
        }

        return list;
    }
}
