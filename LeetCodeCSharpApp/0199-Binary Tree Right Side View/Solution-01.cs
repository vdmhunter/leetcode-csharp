// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract

using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.BinaryTreeRightSideView01;

public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();
        
        if (root == null)
            return result.ToArray();

        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while (q.Count > 0)
        {
            var size = q.Count;
            for (var i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                
                if (i == 0)
                    result.Add(node.val);

                if (node.right != null)
                    q.Enqueue(node.right);

                if (node.left != null)
                    q.Enqueue(node.left);
            }
        }

        return result.ToArray();
    }
}
