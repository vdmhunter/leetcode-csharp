using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LinkedListCycleII02;

public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null)
            return null!;

        var nodeList = new HashSet<ListNode>();

        while (nodeList.Add(head))
        {
            head = head.next;

            if (head == null)
                return null!;
        }

        return head;
    }
}
