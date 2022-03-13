/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
 
public class MyQueue 
{
    private Stack<int> _pushStack;
    private Stack<int> _popStack;
     
    /** Initialize your data structure here. */
    public MyQueue() 
    {
        _pushStack = new Stack<int>();
        _popStack = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) 
    {
        _pushStack.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop()
    {
        Move();
        return _popStack.Pop();
    }
     
    /** Get the front element. */
    public int Peek() 
    {
        Move();
        return _popStack.Peek();    
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() 
    {
        return _pushStack.Count == 0 && _popStack.Count == 0;       
    }
    
    private void Move()
    {
        if(_popStack.Count != 0)
            return;
        
        while(_pushStack.Count != 0)
        {
            var m= _pushStack.Pop();
            _popStack.Push(m);
        }
    }
}