using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MergeKSortedLists01;

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var pq = new PriorityQueue<ListNode, int>();

        foreach (var l in lists)
            if (l != null)
                pq.Enqueue(l, l.val);

        var root = new ListNode();
        var current = root;

        while (pq.Count > 0)
        {
            var node = pq.Dequeue();

            if (node.next != null)
                pq.Enqueue(node.next, node.next.val);

            current.next = new ListNode(node.val);
            current = current.next;
        }

        return root.next;
    }
}
