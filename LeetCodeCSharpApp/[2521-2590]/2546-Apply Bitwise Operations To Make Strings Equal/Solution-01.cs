namespace LeetCodeCSharpApp.ApplyBitwiseOperationsToMakeStringsEqual01;

public class Solution
{
    public bool MakeStringsEqual(string s, string target)
    {
        return s.Contains("1") == target.Contains("1");
    }
}
