using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ReverseLinkedListII01;

/// <summary>
/// Recursion
/// </summary>
public class Solution
{
    // Object level variables since we need the changes
    // to persist across recursive calls and Java is pass by value.
    private bool _stop;
    private ListNode? _leftNode;

    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        _leftNode = head;
        _stop = false;

        RecurseAndReverse(head, left, right);

        return head;
    }

    private void RecurseAndReverse(ListNode rightNode, int left, int right)
    {
        // Base case. Don't proceed any further
        if (right == 1)
            return;

        // Keep moving the right pointer one step forward until (n == 1)
        rightNode = rightNode.next;

        // Keep moving left pointer to the right until we reach the proper node
        // from where the reversal is to start.
        if (left > 1)
            _leftNode = _leftNode!.next;

        // Recurse with m and n reduced.
        RecurseAndReverse(rightNode, left - 1, right - 1);

        // In case both the pointers cross each other or become equal, we
        // stop i.e. don't swap data any further. We are done reversing at this
        // point.
        if (_leftNode == rightNode || rightNode.next == _leftNode)
            _stop = true;

        // Until the boolean stop is false, swap data between the two pointers
        if (_stop)
            return;

        (_leftNode!.val, rightNode.val) = (rightNode.val, _leftNode.val);

        // Move left one step to the right.
        // The right pointer moves one step back via backtracking.
        _leftNode = _leftNode.next;
    }
}
