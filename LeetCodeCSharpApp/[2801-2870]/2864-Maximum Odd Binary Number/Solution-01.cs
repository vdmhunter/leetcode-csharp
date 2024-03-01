namespace LeetCodeCSharpApp.MaximumOddBinaryNumber01;

/// <summary>
///   Greedy Bit Manipulation (Sorting and Swapping)
/// 
///   Time Complexity: O(N * log(N))
///   Space Complexity: O(N)
/// </summary>
public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        char[] arr = s.ToCharArray();
        int n = arr.Length;

        Array.Sort(arr);

        int secondLast = n - 2;

        for (var i = 0; i < n / 2; i++)
            (arr[i], arr[secondLast - i]) = (arr[secondLast - i], arr[i]);

        return new string(arr);
    }
}
