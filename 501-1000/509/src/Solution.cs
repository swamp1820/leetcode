﻿namespace src;

public class Solution
{
    public int Fib(int n)
    {
        if (n == 0 || n == 1)
        {
            return n;
        }
        else
        {
            return Fib(n-1)+Fib(n-2);
        }

    }
}
