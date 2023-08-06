namespace LeetCodeCSharpApp.FaultyKeyboard01;

public class Solution
{
    public string FinalString(string s)
    {
        var result = "";

        foreach (var ch in s)
        {
            if (ch != 'i')
            {
                result += ch;
            }
            else
            {
                var charArray = result.ToCharArray();
                Array.Reverse(charArray);
                result = new string(charArray);
            }
        }

        return result;
    }
}
