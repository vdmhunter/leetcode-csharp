using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.StepByStepDirectionsFromABinaryTreeNodeToAnother01;

public class Solution
{
    public string GetDirections(TreeNode root, int startValue, int destValue)
    {
        var pathToStart = new List<string>();
        var pathToDest = new List<string>();

        if (!FindPath(root, startValue, pathToStart) || !FindPath(root, destValue, pathToDest))
            return "";

        var i = 0;

        while (i < pathToStart.Count && i < pathToDest.Count && pathToStart[i] == pathToDest[i])
            i++;

        var upMoves = new string('U', pathToStart.Count - i);
        string downMoves = string.Join("", pathToDest.GetRange(i, pathToDest.Count - i));

        return upMoves + downMoves;
    }

    private static bool FindPath(TreeNode root, int value, List<string> path)
    {
        if (root == null!)
            return false;

        if (root.val == value)
            return true;

        path.Add("L");

        if (FindPath(root.left, value, path))
            return true;

        path.RemoveAt(path.Count - 1);
        path.Add("R");

        if (FindPath(root.right, value, path))
            return true;

        path.RemoveAt(path.Count - 1);

        return false;
    }
}
