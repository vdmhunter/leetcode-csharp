namespace LeetCodeCSharpApp.FindFirstPalindromicStringInTheArray02;

public class Solution
{
    public string FirstPalindrome(string[] words)
    {
        foreach (var word in words)
        {
            var arr = word.ToCharArray();
            Array.Reverse(arr);

            if (word == new string(arr))
                return word;
        }

        return "";
    }
}
