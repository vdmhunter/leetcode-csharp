namespace LeetCodeCSharpApp.CompareVersionNumbers01;

public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        string[] levels1 = version1.Split('.');
        string[] levels2 = version2.Split('.');

        int length = Math.Max(levels1.Length, levels2.Length);

        for (var i = 0; i < length; i++)
        {
            int v1 = i < levels1.Length ? int.Parse(levels1[i]) : 0;
            int v2 = i < levels2.Length ? int.Parse(levels2[i]) : 0;
            int compare = v1.CompareTo(v2);

            if (compare != 0)
                return compare;
        }

        return 0;
    }
}
