namespace LeetCodeCSharpApp.UniqueMorseCodeWords01;

public class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        var morseCodes = new Dictionary<char, string>
        {
            { 'a', ".-" }, { 'b', "-..." }, { 'c', "-.-." }, { 'd', "-.." },
            { 'e', "." }, { 'f', "..-." }, { 'g', "--." }, { 'h', "...." },
            { 'i', ".." }, { 'j', ".---" }, { 'k', "-.-" }, { 'l', ".-.." },
            { 'm', "--" }, { 'n', "-." }, { 'o', "---" }, { 'p', ".--." },
            { 'q', "--.-" }, { 'r', ".-." }, { 's', "..." }, { 't', "-" },
            { 'u', "..-" }, { 'v', "...-" }, { 'w', ".--" }, { 'x', "-..-" },
            { 'y', "-.--" }, { 'z', "--.." }
        };

        var transformations = new HashSet<string>();

        foreach (var word in words)
        {
            var morseWord = word.Aggregate("", (current, next) => current + morseCodes[next]);
            transformations.Add(morseWord);
        }

        return transformations.Count;
    }
}
