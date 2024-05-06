using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.RemoveNodesFromLinkedList01;

public class Solution
{
    public ListNode RemoveNodes(ListNode head)
    {
        if (head == null!)
            return null!;

        head.next = RemoveNodes(head.next);

        return head.next != null! && head.val < head.next.val ? head.next : head;
    }
}
