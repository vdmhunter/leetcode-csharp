using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MergeNodesInBetweenZeros01;

public class Solution
{
    public ListNode MergeNodes(ListNode head)
    {
        ListNode dummy = new(), cur = dummy;
        var sum = 0;
        head = head.next;

        while (head != null!)
        {
            if (head.val == 0)
            {
                cur.next = new ListNode(sum);
                cur = cur.next;
                sum = 0;
            }

            sum += head.val;
            head = head.next;
        }

        return dummy.next;
    }
}
