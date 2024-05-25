namespace LeetCodeCSharpApp.WordBreakII01;

public class Solution
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        var dict = new HashSet<string>(wordDict);

        return WordBreakHelper(s, 0, dict);
    }

    private static List<string> WordBreakHelper(string s, int start, HashSet<string> dict)
    {
        var validSubstr = new List<string>();

        if (start == s.Length)
        {
            validSubstr.Add("");

            return validSubstr;
        }

        for (int end = start + 1; end <= s.Length; end++)
        {
            string prefix = s.Substring(start, end - start);

            if (!dict.Contains(prefix))
                continue;

            IList<string> suffixes = WordBreakHelper(s, end, dict);

            validSubstr.AddRange(
                suffixes.Select(
                    sfx => prefix + (string.IsNullOrEmpty(sfx) ? "" : " ") + sfx));
        }

        return validSubstr;
    }
}
