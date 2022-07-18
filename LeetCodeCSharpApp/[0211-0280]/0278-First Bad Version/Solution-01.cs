namespace LeetCodeCSharpApp.FirstBadVersion01;

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int start = 1, end = n;
        
        while (start < end)
        {
            var mid = start + (end - start) / 2;
            
            if (!IsBadVersion(mid))
                start = mid + 1;
            else
                end = mid;
        }

        return start;
    }
}

public class VersionControl
{
    protected static bool IsBadVersion(int version)
    {
        return version == 4;
    }
}
