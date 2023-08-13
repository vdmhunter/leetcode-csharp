using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.DoubleANumberRepresentedAsALinkedList02;

public class Solution
{
    public ListNode DoubleIt(ListNode head)
    {
        if (head.val > 4)
            head = new ListNode(0, head);

        for (var node = head; node != null; node = node.next)
        {
            node.val = node.val * 2 % 10;

            if (node.next is { val: > 4 })
                node.val++;
        }

        return head;
    }
}
