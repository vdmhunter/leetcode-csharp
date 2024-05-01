namespace LeetCodeCSharpApp.ReversePrefixOfWord01;

public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        int p = word.IndexOf(ch);

        if (p == -1)
            return word;

        char[] arr = word.ToCharArray();
        Array.Reverse(arr, 0, p + 1);
        word = new string(arr);

        return word;
    }
}
