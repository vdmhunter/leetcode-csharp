namespace LeetCodeCSharpApp.SubstringWithConcatenationOfAllWords01;

public class Solution
{
    private int _wordsCount;
    private int _wordLength;
    private List<int>? _resultIndices;
    private Dictionary<string, int>? _wordFrequency;

    public IList<int> FindSubstring(string s, string[] words)
    {
        if (s == string.Empty || words.Length == 0)
            return new List<int>();

        _wordFrequency = new Dictionary<string, int>();

        foreach (var w in words)
        {
            if (!_wordFrequency.ContainsKey(w))
                _wordFrequency.Add(w, 0);

            _wordFrequency[w]++;
        }

        _wordsCount = words.Length;
        _wordLength = words[0].Length;
        _resultIndices = new List<int>();

        // We only add a valid substring to the result on 3 conditions: 
        // -- (1): wordFrequency contains the wordSeen; 
        // -- (2): wordFrequency contains the same frequency as wordSeen; 
        // -- (3): iteration is complete over words (we must arrive at the last word)

        // Because each valid substring would have exactly one word from the words array, 
        // the minimum length substring would be word[0].length (since all have same length) * word.Length
        // (i.e. total number of items in the words array)
        // the sliding window will be the first substring of s, 
        // ensuring that the maximum length of the window is words[0].length,
        // because we will be analysing the substring in groups of 3
        // first sliding window is at (total length - wordsCount * wordLength + 1)

        for (var i = 0; i < s.Length - _wordsCount * _wordLength + 1; i++)
            Slide(s, i);

        return _resultIndices;
    }

    private void Slide(string s, int i)
    {
        var wordsSeen = new Dictionary<string, int>();

        //loop through the words array
        for (var j = 0; j < _wordsCount; j++) //j is the number of words iterated in array
        {
            var validSubstring = UpdateWordsSeenAndGetValidSubstring(wordsSeen, s, i, j);

            if (validSubstring == string.Empty || wordsSeen[validSubstring] > _wordFrequency![validSubstring])
                break; // break if there are more words seen than words available

            if (j + 1 == _wordsCount) //if we have completed iteration of words array
                _resultIndices!.Add(i); //valid substring added to resultIndices                
        }
    }

    private string UpdateWordsSeenAndGetValidSubstring(IDictionary<string, int> wordsSeen, string s, int i, int j)
    {
        var nextWordIndex = i + j * _wordLength; //1 + 0 * 3 = 1
        // get the next word from the string
        var validSubstring = s.Substring(nextWordIndex, _wordLength); // nextWordIndex + wordLength is (END - 1) 

        if (!_wordFrequency!.ContainsKey(validSubstring))
            return string.Empty; // break if we don't need this word

        if (!wordsSeen.ContainsKey(validSubstring))
            wordsSeen.Add(validSubstring, 0);

        wordsSeen[validSubstring]++;

        return validSubstring;
    }
}
