namespace LeetCodeCSharpApp.FirstLetterToAppearTwice01;

public class Solution
{
    public char RepeatedCharacter(string s)
    {
        var dic = new HashSet<char>();

        foreach (var c in s)
            if (!dic.Contains(c))
                dic.Add(c);
            else
                return c;

        return s[0];
    }
}
