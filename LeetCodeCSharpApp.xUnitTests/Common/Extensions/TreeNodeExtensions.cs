using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.xUnitTests.Common.Extensions;

[ExcludeFromCodeCoverage]
public static class TreeNodeExtensions
{
    private static readonly Regex BinaryTreeRegex = new("^(\\[\\]|\\[((\\d+|null),)*(\\d+|null)\\])$");

    public static TreeNode ToBinaryTree(this string nodes)
    {
        if (!BinaryTreeRegex.IsMatch(nodes))
            throw new FormatException();

        var array = nodes == "[]"
            ? Array.Empty<int?>()
            : nodes[1..^1].Split(",").Select(n => n == "null" ? (int?)null : Convert.ToInt32(n)).ToArray();

        if (array.Length > 0 && array[0] == null)
            throw new FormatException();

        return array.ToBinaryTree();
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public static TreeNode ToBinaryTree(this IReadOnlyList<int?> nodes)
    {
        return InsertLevelOrder(nodes, 0);
    }

    public static IEnumerable<int> ToNlrArray(this TreeNode tree)
    {
        var list = new List<int>();
        var rights = new Stack<TreeNode>();

        while (tree != null)
        {
            list.Add(tree.val);

            if (tree.right != null)
                rights.Push(tree.right);

            tree = tree.left;

            if (tree == null && rights.Count != 0)
                tree = rights.Pop();
        }

        return list.ToArray();
    }

    private static TreeNode InsertLevelOrder(IReadOnlyList<int?> array, int i)
    {
        //TODO: Check version [1,5,3,null,4,10,6,9,2]
        TreeNode root = null!;

        if (i >= array.Count)
            return root;

        var leftIndex = 2 * i + 1;
        var rightIndex = 2 * i + 2;

        root = new TreeNode(array[i]!.Value)
        {
            left = leftIndex < array.Count && array[leftIndex].HasValue
                ? InsertLevelOrder(array, leftIndex)
                : null!,
            right = rightIndex < array.Count && array[rightIndex].HasValue
                ? InsertLevelOrder(array, rightIndex)
                : null!
        };

        return root;
    }
}
