namespace LeetCodeCSharpApp.SumOfSubarrayMinimums01;

public class Solution
{
    private const long M = 1000000007;

    public int SumSubarrayMins(int[] arr)
    {
        // validations
        if (arr == null! || arr.Length == 0)
            return 0;

        long sum = 0;
        var stack = new Stack<int>();

        // traverse the array
        for (var i = 0; i <= arr.Length; i++)
        {
            // check if stack is > 0
            // if so, check if current value is smaller than top of stack
            while (stack.Count > 0 && arr[stack.Peek()] > (i == arr.Length ? int.MinValue : arr[i]))
            {
                // if arr[i] < arr[stack.Peek()], we need to pop 
                // until we find an index where the value was smaller
                // each time we pop, recalculate the min for the subarray
                var mid = stack.Pop();

                // left bound is previous stack entry (or beginning of array)
                var left = stack.Count == 0 ? -1 : stack.Peek();

                // right bound is our current index (or end of array)

                // multiple the min value by number of sub-arrays that include it
                sum += (long)arr[mid] * (mid - left) * (i - mid);
            }

            stack.Push(i);
        }

        return (int)(sum % M);
    }
}
