namespace LeetCodeCSharpApp.WordLadderII;

public class Solution
{
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        var result = new List<IList<string>>();
        var (shortestPathLength, graph) = ComputeGraph(beginWord, endWord, wordList);
        
        if (graph == null)
            return result;

        var path = new string[shortestPathLength];
        
        FindPaths(endWord, 0);
        
        return result;

        void FindPaths(string w, int position)
        {
            path[shortestPathLength - (position + 1)] = w;
            
            if (position == shortestPathLength - 1)
                result.Add(path.ToList());
            else if (graph.ContainsKey(w))
                foreach (var nextWord in graph[w])
                    FindPaths(nextWord, position + 1);
        }
    }

    private static (int ShortestPathLength, Dictionary<string, HashSet<string>> Graph) ComputeGraph(string beginWord,
        string endWord, ICollection<string> wordList)
    {
        var graph = new Dictionary<string, HashSet<string>>();

        var q = new Queue<string>();
        q.Enqueue(beginWord);

        var used = new HashSet<string>(wordList.Count + 1);
        var usedInIteration = new HashSet<string>(wordList.Count + 1);
        var endIsReached = false;
        var pathLength = 1;
        
        while (q.Count > 0)
        {
            var iterationCount = q.Count;

            for (var i = 0; i < iterationCount; i++)
            {
                var current = q.Dequeue();
                used.Add(current);

                endIsReached = EndIsReached(current);
            }

            if (endIsReached)
                return (pathLength + 1, graph);

            foreach (var usedContinuation in usedInIteration)
                used.Add(usedContinuation);
            
            usedInIteration.Clear();
            pathLength++;
        }

        return (int.MaxValue, null)!;

        bool EndIsReached(string current)
        {
            var continuations = wordList.Where(w => !used.Contains(w) && HaveOneLetterDifference(w, current));
            
            foreach (var possibleContinuation in continuations)
            {
                if (possibleContinuation == endWord)
                    endIsReached = true;
                else if (!usedInIteration.Contains(possibleContinuation))
                {
                    q.Enqueue(possibleContinuation);
                    usedInIteration.Add(possibleContinuation);
                }

                if (!graph.ContainsKey(possibleContinuation))
                    graph[possibleContinuation] = new HashSet<string>();

                graph[possibleContinuation].Add(current);
            }

            return endIsReached;
        }
    }

    private static bool HaveOneLetterDifference(string a, string b)
    {
        var hadDifference = false;
        
        for (var i = 0; i < a.Length; i++)
            if (a[i] != b[i])
            {
                if (hadDifference)
                    return false;
                
                hadDifference = true;
            }

        return hadDifference;
    }
}
