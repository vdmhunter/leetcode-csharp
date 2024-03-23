using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ReorderList01;

public class Solution
{
    public void ReorderList(ListNode head)
    {
        var nodes = new List<ListNode>();

        while (head != null!)
        {
            nodes.Add(head);
            head = head.next;
        }

        var reorderedHead = new ListNode();
        ListNode reordered = reorderedHead;

        int n = nodes.Count;

        for (var i = 0; i < n; i++)
        {
            reordered.next = i % 2 == 0
                ? nodes[i / 2]
                : nodes[n - 1 - i / 2];

            reordered = reordered.next;
        }

        reordered.next = null!;
    }
}
