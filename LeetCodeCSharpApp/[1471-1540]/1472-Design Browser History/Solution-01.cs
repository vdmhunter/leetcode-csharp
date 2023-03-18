namespace LeetCodeCSharpApp.DesignBrowserHistory01;

public class BrowserHistory
{
    private readonly List<string> _history;
    private int _curUrlIdx;
    private int _length;

    public BrowserHistory(string homepage)
    {
        _history = new List<string> { homepage };

        _curUrlIdx = 0;
        _length = 1;
    }

    public void Visit(string url)
    {
        if (_curUrlIdx == _history.Count - 1)
            _history.Add(url);

        else
            _history[_curUrlIdx + 1] = url;

        _curUrlIdx++;
        _length = _curUrlIdx + 1;
    }

    public string Back(int steps)
    {
        while (_curUrlIdx > 0 && steps > 0)
        {
            _curUrlIdx--;
            steps--;
        }

        return _history[_curUrlIdx];
    }

    public string Forward(int steps)
    {
        while (_curUrlIdx < _length - 1 && steps > 0)
        {
            _curUrlIdx++;
            steps--;
        }

        return _history[_curUrlIdx];
    }
}
