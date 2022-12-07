using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.OddEvenLinkedList02;

public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null!)
            return head!;

        var headEven = OddEvenList(head, head.next);
        var headOdd = head;
        
        while (head.next != null!)
            head = head.next;
        
        head.next = headEven;
        
        return headOdd;
    }

    private static ListNode OddEvenList(ListNode node, ListNode nextNode)
    {
        if (nextNode == null!)
            return nextNode!;
        
        node.next = OddEvenList(nextNode, nextNode.next);
        
        return nextNode;
    }
}
