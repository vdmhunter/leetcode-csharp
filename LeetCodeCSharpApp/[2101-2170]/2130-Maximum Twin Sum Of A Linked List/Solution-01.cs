using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.MaximumTwinSumOfALinkedList01;

public class Solution
{
    public int PairSum(ListNode head)
    {
        ListNode l1 = head, l2 = head;
        var s1 = new Stack<int>();

        while (l2 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
            l2 = l2.next.next;
        }

        var result = 0;

        while (s1.Count > 0)
        {
            result = Math.Max(result, s1.Pop() + l1.val);
            l1 = l1.next;
        }

        return result;
    }
}
