

/*  1 - misol */

/*public class MyStack
{
    private Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        int size = queue.Count;
        queue.Enqueue(x);

        // Qolgan elementlarni o'zgartirish
        for (int i = 0; i < size; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }

    public int Pop()
    {
        if (queue.Count > 0)
        {
            return queue.Dequeue();
        }
        return -1; 
    }

    public int Top()
    {
        if (queue.Count > 0)
        {
            return queue.Peek();
        }
        return -1; 
    }

    public bool Empty()
    {
        return queue.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        MyStack myStack = new MyStack();

        Console.WriteLine(myStack.Push(1)); 
        Console.WriteLine(myStack.Push(2)); 
        Console.WriteLine(myStack.Top());    
        Console.WriteLine(myStack.Pop());   
        Console.WriteLine(myStack.Empty()); 
    }
}
*/


/*  1 - misol */


/* 3 - misol*/

/*public class CustomStack
{
    int[] stack;
    int i;
    public CustomStack(int maxSize)
    {
        stack = new int[maxSize];
        i = -1;
    }

    public void Push(int x)
    {
        if (i < stack.Length - 1)
        {
            i++;
            stack[i] = x;
        }
    }

    public int Pop()
    {
        if (i > -1)
            return stack[i--];
        else return -1;
    }

    public void Increment(int k, int val)
    {
        int j = 0;
        while (j < k && j < stack.Length)
        {
            stack[j] += val;
            j++;
        }
    }
}
*/



/* 3 - misol*/