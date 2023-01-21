namespace LeetCodeCSharpApp.RestoreIPAddresses01;

public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        var result = new List<string>();
        var tempList = new List<string>();

        Helper(s, result, tempList);

        return result;
    }

    private void Helper(string s, List<string> result, List<string> tempList)
    {
        if (tempList.Count == 4)
        {
            if (s.Length == 0)
                result.Add(string.Join(".", tempList));

            return;
        }

        FindValidSubstrings(s, result, tempList);
    }

    private void FindValidSubstrings(string s, List<string> result, List<string> tempList)
    {
        for (var i = 1; i <= 3; i++)
        {
            if (s.Length < i)
                break;

            var substring = s[..i];

            if (int.Parse(substring) > 255 || (substring.StartsWith('0') && substring.Length != 1))
                continue;

            tempList.Add(substring);
            Helper(s.Length == i ? "" : s[i..], result, tempList);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}
