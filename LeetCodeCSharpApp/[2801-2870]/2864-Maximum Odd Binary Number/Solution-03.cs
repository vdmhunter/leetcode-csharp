namespace LeetCodeCSharpApp.MaximumOddBinaryNumber03;

/// <summary>
///   Greedy Bit Manipulation (One Pass with Two Pointers)
///
///   Time Complexity: O(N)
///   Space Complexity: O(N)
/// </summary>
public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        char[] arr = s.ToCharArray();
        int n = arr.Length;
        int left = 0, right = n - 1;

        while (left <= right)
        {
            if (arr[left] == '1')
                left++;

            if (arr[right] == '0')
                right--;

            if (left > right || arr[left] != '0' || arr[right] != '1')
                continue;

            arr[left] = '1';
            arr[right] = '0';
        }

        arr[left - 1] = '0';
        arr[n - 1] = '1';

        return new string(arr);
    }
}
