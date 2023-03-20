namespace LeetCodeCSharpApp.DesignAddAndSearchWordsDataStructure02;

public class WordDictionary
{
    private readonly Dictionary<int, Dictionary<char, HashSet<string>>> _mainDict;

    public WordDictionary()
    {
        _mainDict = new Dictionary<int, Dictionary<char, HashSet<string>>>();
    }

    public void AddWord(string word)
    {
        if (_mainDict.ContainsKey(word.Length))
        {
            if (_mainDict[word.Length].ContainsKey(word[0]))
                _mainDict[word.Length][word[0]].Add(word);
            else
            {
                _mainDict[word.Length].Add(word[0], new HashSet<string>());
                _mainDict[word.Length][word[0]].Add(word);
            }
        }
        else
        {
            _mainDict.Add(word.Length, new Dictionary<char, HashSet<string>>());
            _mainDict[word.Length].Add(word[0], new HashSet<string>());
            _mainDict[word.Length][word[0]].Add(word);
        }
    }

    public bool Search(string word)
    {
        if (!_mainDict.ContainsKey(word.Length))
            return false;

        if (word[0] == '.')
            return _mainDict[word.Length].Keys.Any(key => SearchByKey(word, key));

        return _mainDict[word.Length].ContainsKey(word[0]) && SearchByKey(word, word[0]);
    }

    private bool SearchByKey(string word, char key)
    {
        return _mainDict[word.Length][key].Any(str => !str.Where((t, i) => word[i] != '.' && word[i] != t).Any());
    }
}
