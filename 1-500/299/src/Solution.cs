namespace src;

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        int bulls = 0;
        int cows = 0;
        var visitedSecret = new List<int>();
        var visitedGuess = new List<int>();
        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
            }
            else
            {
                // проверим была ли такая цифра уже
                if (visitedGuess.Contains(secret[i]))
                {
                    visitedGuess.Remove(secret[i]);
                    cows++;
                }
                else
                {
                    visitedSecret.Add(secret[i]);
                }

                if (visitedSecret.Contains(guess[i]))
                {
                    visitedSecret.Remove(guess[i]);
                    cows++;
                }
                else
                {
                    visitedGuess.Add(guess[i]);
                }
            }
        }


        return bulls + "A" + cows + "B";
    }
}