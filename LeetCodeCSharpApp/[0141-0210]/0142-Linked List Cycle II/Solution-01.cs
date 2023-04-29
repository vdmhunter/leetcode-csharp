using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LinkedListCycleII01;

public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (fast != slow)
                continue;

            var slow2 = head;

            while (slow2 != slow)
            {
                slow = slow.next;
                slow2 = slow2.next;
            }

            return slow;
        }

        return null!;
    }
}
