using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConvertBinaryNumberInALinkedListToInteger01;

public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        var sum = 0;

        while (head != null)
        {
            sum *= 2;
            sum += head.val;
            head = head.next;
        }

        return sum;
    }
}
