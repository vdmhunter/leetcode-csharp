using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.DeleteTheMiddleNodeOfALinkedList01;

public class Solution
{
    public ListNode DeleteMiddle(ListNode? head)
    {
        if (head?.next == null)
            return null!;

        ListNode prev = head, slow = head, fast = head;

        while (fast.next != null!)
        {
            prev = slow;
            slow = slow.next;

            if (fast.next.next == null!)
                break;

            fast = fast.next.next;
        }

        prev.next = prev.next.next;

        return head;
    }
}
