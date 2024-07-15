using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.CreateBinaryTreeFromDescriptions01;

public class Solution
{
    public TreeNode CreateBinaryTree(int[][] descriptions)
    {
        var dict = new Dictionary<int, TreeNode>(descriptions.Length);
        int rootVal = descriptions.Select(x => x[0]).Except(descriptions.Select(x => x[1])).Single();

        foreach (int[] d in descriptions)
        {
            if (!dict.ContainsKey(d[0]))
                dict.Add(d[0], new TreeNode(d[0]));

            if (!dict.ContainsKey(d[1]))
                dict.Add(d[1], new TreeNode(d[1]));

            if (d[2] == 1)
                dict[d[0]].left = dict[d[1]];
            else
                dict[d[0]].right = dict[d[1]];
        }

        return dict[rootVal];
    }
}
