using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.RemoveNthNodeFromEndOfList02;

/// <summary>
/// Slow Fast
/// </summary>
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new(0, head);
        ListNode slow = dummy, fast = dummy;

        // Gap of fast and slow is n
        for (var i = 0; i < n; i++) fast = fast.next;

        // Move slow to the node behind the node to delete
        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        // Delete the node
        slow.next = slow.next.next;

        return dummy.next;
    }
}
