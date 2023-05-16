using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SwapNodesInPairs02;

public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head?.next == null)
            return head!;

        var next = head.next;
        head.next = SwapPairs(head.next.next);
        next.next = head;

        return next;
    }
}
