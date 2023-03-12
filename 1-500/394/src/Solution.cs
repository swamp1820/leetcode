namespace src;

public class Solution
{
    string result = string.Empty;
    public string DecodeString(string s)
    {
        int startSubstring = 0;
        int endSubstring = 0;
        int numIndex = 0;
        string numStr = "0";
        // если числа нет - выходим
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            // найдем число
            if (num == 0 && s[i] >= '0' && s[i] <= '9')
            {
                if (numStr == "0")
                {
                    numIndex = i;
                }
                numStr = numStr + (s[i] - '0');
                continue;
            }
            // найдем начало и конец строки
            if (s[i] == '[')
            {
                num = int.Parse(numStr);
                startSubstring = i;
                var stack = new Stack<string>();
                stack.Push("[");
                while (stack.Count != 0)
                {
                    i++;
                    if (s[i] == ']')
                    {
                        stack.Pop();
                    }
                    else if (s[i] == '[')
                    {
                        stack.Push("[");
                    }
                }

                endSubstring = i;
                break;
            }
        }

        if (num == 0)
        {
            return s;
        }
        return DecodeString(s.Substring(0, numIndex) + StrMultiply(num, s.Substring(startSubstring + 1, endSubstring - (startSubstring + 1))) + s.Substring(endSubstring + 1));
    }

    private string StrMultiply(int count, string s)
    {
        string result = string.Empty;
        for (int i = 0; i < count; i++)
        {
            result = result + s;
        }

        return result;
    }
}