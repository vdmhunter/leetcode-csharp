using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConvertSortedListToBinarySearchTree01;

public class Solution
{
    public TreeNode SortedListToBST(ListNode head)
    {
        var nodes = new List<int>();

        while (head != null)
        {
            nodes.Add(head.val);
            head = head.next;
        }

        return CreateTree(nodes, 0, nodes.Count - 1);
    }

    private static TreeNode CreateTree(List<int> nodes, int start, int end)
    {
        if (start > end)
            return null!;

        var mid = (start + end) / 2;
        var node = new TreeNode(nodes[mid])
        {
            left = CreateTree(nodes, start, mid - 1),
            right = CreateTree(nodes, mid + 1, end)
        };

        return node;
    }
}
