namespace LeetCodeCSharpApp.LexicographicallySmallestBeautifulString01;

public class Solution
{
    public string SmallestBeautifulString(string s, int k)
    {
        var arr = s.ToCharArray();

        for (var i = s.Length - 1; i >= 0; i--)
        {
            arr[i]++;

            while (!Valid(arr, i))
                arr[i]++;

            if (arr[i] >= 'a' + k)
                continue;

            for (i += 1; i < s.Length; i++)
            {
                arr[i] = 'a';

                while (!Valid(arr, i))
                    arr[i]++;
            }

            return new string(arr);
        }

        return "";
    }

    private static bool Valid(char[] arr, int i)
    {
        return (i < 1 || arr[i] != arr[i - 1]) && (i < 2 || arr[i] != arr[i - 2]);
    }
}
