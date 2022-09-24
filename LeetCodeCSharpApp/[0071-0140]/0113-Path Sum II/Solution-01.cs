using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PathSumII01;

public class Solution
{
    private readonly List<IList<int>> _result = new();

    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        Search(root, targetSum, 0, new List<int>());
        
        return _result;
    }

    private void Search(TreeNode node, int targetSum, int currentSum, IList<int> path)
    {
        if (node == null)
            return;

        // Add the node to this path
        path.Add(node.val);

        // Add the current value to the running total
        currentSum += node.val;

        // Since this is a root-to-leaf check, evaluate for the 
        // success condition when both left and right nodes are null
        if (node.left == null && node.right == null)
            // Check to see if current value equals target
            if (currentSum == targetSum)
                _result.Add(new List<int>(path));

        // Keep exploring along branches finding the target sum
        Search(node.left!, targetSum, currentSum, path);
        Search(node.right!, targetSum, currentSum, path);

        // Remove the last item added as this path has already been explored
        path.RemoveAt(path.Count - 1);
    }
}
