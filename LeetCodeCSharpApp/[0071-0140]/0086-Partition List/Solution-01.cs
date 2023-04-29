using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.PartitionList01;

public class Solution
{
    public ListNode Partition(ListNode head, int x)
    {
        ListNode smallerHead = new(), biggerHead = new();
        ListNode smaller = smallerHead, bigger = biggerHead;

        while (head != null)
        {
            if (head.val < x)
                smaller = smaller.next = head;
            else
                bigger = bigger.next = head;

            head = head.next;
        }

        smaller.next = biggerHead.next;
        bigger.next = null!;

        return smallerHead.next;
    }
}
