using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.AddTwoNumbers01;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        if (l1 == null && l2 == null)
            return null!;

        var v1 = l1?.val ?? 0;
        var v2 = l2?.val ?? 0;

        var flag = v1 + v2 >= 10;
        var v = (v1 + v2) % 10;

        var nextNode = l1?.next ?? l2?.next;

        if(flag && nextNode != null)
            nextNode.val += 1;

        if (flag && nextNode == null)
        {
            var node = l1 ?? l2;
            node!.next = new ListNode(1);
        }

        return new ListNode(v, AddTwoNumbers(l1?.next!, l2?.next!));
    }
}
