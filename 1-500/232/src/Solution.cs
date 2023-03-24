namespace src;

public class MyQueue
{

    Stack<int> queueStack = new Stack<int>();
    Stack<int> helpStack = new Stack<int>();
    public MyQueue()
    {

    }

    public void Push(int x)
    {
        // перенесем все элементы в вспомогательный стек
        while (queueStack.Count > 0)
        {
            helpStack.Push(queueStack.Pop());
        }
        // закинем новый элемент
        queueStack.Push(x);

        // перенесем все элементы обратно
        while (helpStack.Count > 0)
        {
            queueStack.Push(helpStack.Pop());
        }
    }

    public int Pop()
    {
        return queueStack.Pop();
    }

    public int Peek()
    {
        return queueStack.Peek();
    }

    public bool Empty()
    {
        return queueStack.Count == 0;
    }
}