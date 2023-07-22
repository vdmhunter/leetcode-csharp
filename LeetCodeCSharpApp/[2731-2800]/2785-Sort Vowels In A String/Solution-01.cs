namespace LeetCodeCSharpApp.SortVowelsInAString01;

public class Solution
{
    public string SortVowels(string s)
    {
        var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var vowelArray = s.Where(c => vowels.Contains(c)).OrderBy(c => c).ToArray();
        var index = 0;
        var result = s.ToCharArray();

        for (var i = 0; i < result.Length; i++)
        {
            if (!vowels.Contains(result[i]))
                continue;

            result[i] = vowelArray[index];
            index++;
        }

        return new string(result);
    }
}
