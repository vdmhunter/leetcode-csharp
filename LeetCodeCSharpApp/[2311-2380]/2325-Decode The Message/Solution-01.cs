using System.Text;

namespace LeetCodeCSharpApp.DecodeTheMessage01;

public class Solution
{
    public string DecodeMessage(string key, string message)
    {
        var substitutionTable = new Dictionary<char, char>(26);

        var currentLetter = 'a';
        const char lastLetter = (char)('z' + 1);

        foreach (var c in key.Where(c => !substitutionTable.ContainsKey(c) && c != ' '))
        {
            substitutionTable[c] = currentLetter;
            currentLetter = (char)(currentLetter + 1);

            if (currentLetter == lastLetter)
                break;
        }

        var result = new StringBuilder();

        foreach (var c in message)
        {
            if (c == ' ')
            {
                result.Append(' ');

                continue;
            }

            result.Append(substitutionTable[c]);
        }

        return result.ToString();
    }
}
