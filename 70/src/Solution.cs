namespace src;

public class Solution
{
    // использование словаря значительно ускоряет подсчет
    Dictionary<int, int> memo = new Dictionary<int, int>();
    public int ClimbStairs(int n)
    {
        if (memo.TryGetValue(n, out int i))
        {
            return i;
        }
        if (n < 4)
        {
            return n;
        }
        var p = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        memo.TryAdd(n,p);
        return p;
    }
}
