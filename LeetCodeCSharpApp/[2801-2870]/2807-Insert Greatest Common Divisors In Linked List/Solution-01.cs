using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.InsertGreatestCommonDivisorsInLinkedList01;

public class Solution
{
    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        if (head?.next == null)
            return head!;

        var p = head;

        while (p.next != null)
        {
            var node = new ListNode(Gcd(p.val, p.next.val));
            var on = p.next;
            p.next = node;
            node.next = on;
            p = on;
        }

        return head;
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
