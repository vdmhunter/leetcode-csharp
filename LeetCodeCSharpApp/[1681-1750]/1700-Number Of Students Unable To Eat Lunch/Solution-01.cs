namespace LeetCodeCSharpApp.NumberOfStudentsUnableToEatLunch01;

public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        int[] count = [0, 0];
        int n = students.Length;
        int k;

        foreach (int a in students)
            count[a]++;

        for (k = 0; k < n && count[sandwiches[k]] > 0; k++)
            count[sandwiches[k]]--;

        return n - k;
    }
}
