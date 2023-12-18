namespace LeetCodeCSharpApp.MaximumProductDifferenceBetweenTwoPairs01;

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        int largest = 0, secondLargest = 0, smallest = int.MaxValue, secondSmallest = int.MaxValue;

        foreach (var n in nums)
        {
            if (n >= largest)
            {
                secondLargest = largest;
                largest = n;
            }
            else if (n > secondLargest)
            {
                secondLargest = n;
            }

            if (n <= smallest)
            {
                secondSmallest = smallest;
                smallest = n;
            }
            else if (n < secondSmallest)
            {
                secondSmallest = n;
            }
        }

        return largest * secondLargest - smallest * secondSmallest;
    }
}
