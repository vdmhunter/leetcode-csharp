namespace LeetCodeCSharpApp.LexicographicallySmallestBeautifulString01;

public class Solution
{
    public string SmallestBeautifulString(string s, int k)
    {
        var arr = s.ToCharArray();

        for (var i = s.Length - 1; i >= 0; i--)
        {
            IncrementChar(arr, i);

            if (arr[i] >= 'a' + k)
                continue;

            SetRemainingChars(arr, i, s.Length);

            return new string(arr);
        }

        return "";
    }

    private static void IncrementChar(char[] arr, int i)
    {
        arr[i]++;

        while (!Valid(arr, i))
            arr[i]++;
    }

    private static void SetRemainingChars(char[] arr, int i, int length)
    {
        for (i += 1; i < length; i++)
        {
            arr[i] = 'a';
            var count = 0;

            while (!Valid(arr, i) && count < 3)
            {
                arr[i]++;
                count++;
            }
        }
    }

    private static bool Valid(char[] arr, int i)
    {
        return i < 1 || arr[i] != arr[i - 1] && (i < 2 || arr[i] != arr[i - 2]);
    }
}
