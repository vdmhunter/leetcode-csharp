namespace LeetCodeCSharpApp.AddDigits01;

public class Solution
{
    public int AddDigits(int num)
    {
        return num == 0 ? 0 : 1 + (num - 1) % 9;
    }
}
