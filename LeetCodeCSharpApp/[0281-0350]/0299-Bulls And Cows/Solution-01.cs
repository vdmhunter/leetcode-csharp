namespace LeetCodeCSharpApp.BullsAndCows01;

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        var bulls = 0;
        var cows = 0;
        var numbers = new int[10];
        
        for (var i = 0; i < secret.Length; i++)
            if (secret[i] == guess[i])
                bulls++;
            else
            {
                if (numbers[secret[i] - '0']++ < 0)
                    cows++;

                if (numbers[guess[i] - '0']-- > 0)
                    cows++;
            }

        return bulls + "A" + cows + "B";
    }
}
