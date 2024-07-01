namespace LeetCodeCSharpApp.MagneticForceBetweenTwoBalls01;

public class Solution
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        int l = 1, r = position[^1] - position[0];
        int result = -1;

        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            int lastPosition = position[0], balls = 1;

            for (var i = 1; i < position.Length; i++)
            {
                if (position[i] - lastPosition < mid)
                    continue;

                lastPosition = position[i];
                balls++;
            }

            if (balls >= m)
            {
                result = mid;
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return result;
    }
}
