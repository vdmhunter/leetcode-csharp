// ReSharper disable StringLiteralTypo

namespace LeetCodeCSharpApp.LetterCombinationsOfAPhoneNumber01;

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        var map = new Dictionary<char, string>
        {
            { '2', "abc"  },
            { '3', "def"  },
            { '4', "ghi"  },
            { '5', "jkl"  },
            { '6', "mno"  },
            { '7', "pqrs" },
            { '8', "tuv"  },
            { '9', "wxyz" }
        };

        var result = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return result;

        result.Add("");

        foreach (var d in digits)
            result = result.SelectMany(x => map[d].Select(y => x + y)).ToList();

        return result;
    }
}
