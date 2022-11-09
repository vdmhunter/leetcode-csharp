namespace LeetCodeCSharpApp.OnlineStockSpan01;

//
// Your StockSpanner object will be instantiated and called as such:
// StockSpanner obj = new StockSpanner();
// int param_1 = obj.Next(price);
//

public class StockSpanner
{
    private readonly Stack<int[]> stack = new();

    public int Next(int price)
    {
        var result = 1;

        while (stack.Count != 0 && stack.Peek()[0] <= price)
            result += stack.Pop()[1];

        stack.Push(new[] { price, result });

        return result;
    }
}
