namespace src;

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        return Backspace(s)==Backspace(t);
    }

    private string Backspace(string str)
    {
        string newString = string.Empty;
        int backspaceCount = 0;
        for(int i = str.Length-1; i>=0;i--)
        {
            if (str[i]=='#')
            {
                backspaceCount++;
            }
            else
            {
                if (backspaceCount>0)
                { 
                    backspaceCount--;
                }
                else
                {
                    newString+= str[i];
                }
            }
        }

        return newString;
    }
}