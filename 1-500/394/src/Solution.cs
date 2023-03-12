namespace src;

public class Solution
{
    string result = string.Empty;
    // костыльный метод O(n*m), где m - кол-во вложенных подстрок, n - увеличивается до суммы произведения подстрок на повторы плюс начальные символы без повторов
    // после выполнения подсмотрел решения со стеком https://leetcode.com/problems/decode-string/solutions/941309/python-stack-solution-explained/
    public string DecodeString(string s)
    {
        int startSubstring = 0;
        int endSubstring = 0;
        int numIndex = 0;
        string numStr = "0";
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
// если числа не было - значит строка готова
        if (num == 0)
        {
            return s;
        }

        // получаем строку из 3х значений - подстрока ДО числа, декодируемая подстрока, остальная часть строки
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