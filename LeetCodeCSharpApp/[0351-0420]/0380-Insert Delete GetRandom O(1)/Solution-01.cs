namespace LeetCodeCSharpApp.InsertDeleteGetRandomO101;

public class RandomizedSet
{
    private readonly HashSet<int> _set = new();
    private readonly Random _rnd = new();

    public bool Insert(int n) => _set.Add(n);

    public bool Remove(int n) => _set.Remove(n);

    public int GetRandom() => _set.ElementAt(_rnd.Next(_set.Count));
}

// 
// Your RandomizedSet object will be instantiated and called as such:
//
// RandomizedSet obj = new RandomizedSet();
// bool param_1 = obj.Insert(val);
// bool param_2 = obj.Remove(val);
// int param_3 = obj.GetRandom();
// 
