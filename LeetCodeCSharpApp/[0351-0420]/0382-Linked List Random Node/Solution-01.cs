using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.LinkedListRandomNode01;

public class Solution
{
    private readonly ListNode _head;

    public Solution(ListNode head) => _head = head;

    public int GetRandom()
    {
        int scope = 1, chosenValue = 0;
        var curr = _head;
        var rnd = new Random();

        while (curr != null)
        {
            // decide whether to include the element in reservoir
            if (rnd.NextDouble() < 1.0 / scope)
                chosenValue = curr.val;

            // move on to the next node
            scope += 1;
            curr = curr.next;
        }

        return chosenValue;
    }
}
