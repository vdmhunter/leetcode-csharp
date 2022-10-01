namespace LeetCodeCSharpApp.FindDuplicateFileInSystem01;

public class Solution
{
    public IList<IList<string>> FindDuplicate(string[] paths)
    {
        // ReSharper disable once CoVariantArrayConversion
        return paths
            .Select(directoryInfo => directoryInfo.Split(' '))
            .SelectMany(directoryInfo => directoryInfo
                .Skip(1)
                .Select(file => (path: directoryInfo[0], data: file.Split(new[] {'(', ')'},
                    StringSplitOptions.RemoveEmptyEntries))))
            .GroupBy(fileInfo => fileInfo.data[1], fileInfo => $"{fileInfo.path}/{fileInfo.data[0]}")
            .Where(g => g.Count() > 1)
            .Select(g => g.ToList())
            .ToArray();
    }
}
