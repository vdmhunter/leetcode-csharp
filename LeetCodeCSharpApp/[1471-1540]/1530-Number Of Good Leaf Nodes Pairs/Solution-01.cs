using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.NumberOfGoodLeafNodesPairs01;

public class Solution
{
    private int _result;

    public int CountPairs(TreeNode root, int distance)
    {
        Dfs(root, distance);

        return _result;
    }

    private int[] Dfs(TreeNode node, int distance)
    {
        var map = new int[11];

        if (node == null!)
            return map;

        if (node.left == null! && node.right == null!)
            map[1] = 1;

        int[] left = Dfs(node.left!, distance);
        int[] right = Dfs(node.right!, distance);

        for (var i = 1; i < distance; i++)
            for (var j = 1; j <= distance - i; j++)
                _result += left[i] * right[j];

        for (var i = 2; i < 11; i++)
            map[i] += left[i - 1] + right[i - 1];

        return map;
    }
}
