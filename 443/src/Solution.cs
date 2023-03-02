namespace src;

public class Solution
{
    public int Compress(char[] chars)
    {
        return CharSolution(chars).Length;
    }

    public char[] CharSolution(char[] chars)
    {
        char prev = chars[0]; // предыдущий символ
        int repeat = 1; // кол-во повторов
        int position = 0; // текущая позиция
        for (int i = 1; i < chars.Length; i++)
        {
            // если повтор, то просто увеличиваем счетчик повторов
            if (chars[i] == prev)
            {
                repeat++;
            }
            else if (chars[i] != prev) // если символ новый
            {
                // если было много несколько 
                if (repeat > 1)
                {
                    // для каждого разряда запишем символ
                    for (int j = 0; j < Digitity(repeat); j++)
                    {
                        position++; //теперь позиция на числе повторов символа
                        chars[position] = repeat.ToString()[j]; //на следующее место запишем число
                    }

                }
                // запишем новый символ на следующей позиции
                position++;
                chars[position] = chars[i];
                repeat = 1;// сбрасываем счетчик повторов
                prev = chars[position]; // предыдущим символом становится текущий символ
            }

            if (i == chars.Length - 1) //если символ последний
            {
                if (repeat > 1)
                {
                    // для каждого разряда запишем символ
                    for (int j = 0; j < Digitity(repeat); j++)
                    {
                        position++; //теперь позиция на числе повторов символа
                        chars[position] = repeat.ToString()[j]; //на следующее место запишем число
                    }
                }
            }
        }

        return chars[0..++position];
    }

    private int Digitity(int num)
    {
        int count = 1;
        while (num >= 10)
        {
            num = num / 10;
            count++;
        }

        return count;
    }
}