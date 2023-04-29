namespace LeetCodeCSharpApp.GreatestEnglishLetterInUpperAndLowerCase01;

public class Solution
{
    public string GreatestLetter(string s)
    {
        var r = string.Concat(s.OrderByDescending(char.ToUpper).ThenBy(c => c));
        var u = new string(new HashSet<char>(r).ToArray());

        for (var i = 1; i < u.Length; i++)
            if (char.ToUpper(u[i - 1]) == char.ToUpper(u[i]))
                return u[i - 1].ToString();

        return "";
    }
}
