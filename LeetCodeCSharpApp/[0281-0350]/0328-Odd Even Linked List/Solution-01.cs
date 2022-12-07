using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.OddEvenLinkedList01;

public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head.next == null!)
            return head!;

        var odd = head;
        var even = head.next;
        var evenHead = head.next;

        while (true)
        {
            odd.next = even.next;
            
            if (odd.next == null!)
                break;
            
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
            
            if (even == null!)
                break;
        }

        odd.next = evenHead;
        
        return head;
    }
}
