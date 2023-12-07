namespace LeetCodeCSharpApp.LargestOddNumberInString01;

public class Solution
{
    public string LargestOddNumber(string n)
    {
        return n[..(n.LastIndexOfAny(new[] { '1', '3', '5', '7', '9' }) + 1)];
    }
}
