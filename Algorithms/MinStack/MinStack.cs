public class MinStack {
    private Stack<int> stack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();

    public void Push(int x)
    {
        if (this.minStack.Count == 0|| this.minStack.Peek() >= x)
            this.minStack.Push(x);
        this.stack.Push(x);
    }

    public void Pop()
    {
        if (this.minStack.Peek() == this.stack.Peek())
            this.minStack.Pop();
        this.stack.Pop();
    }

    public int Top()
    {
        return this.stack.Peek();
    }

    public int GetMin()
    {
        return this.minStack.Peek();
    }
}