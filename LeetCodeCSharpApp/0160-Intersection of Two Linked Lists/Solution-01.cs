using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.IntersectionOfTwoLinkedLists01;

public class Solution 
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) 
            return null!;
        
        var ptr1 = headA;
        var ptr2 = headB;
        
        while (ptr1 != ptr2)
        {
            ptr1 = ptr1 == null ? headB : ptr1.next;
            ptr2 = ptr2 == null ? headA : ptr2.next;
        }
        
        return ptr1;
    }
}