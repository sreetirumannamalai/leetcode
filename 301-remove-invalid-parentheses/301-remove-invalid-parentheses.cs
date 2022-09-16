public class Solution {
    //Remove Invalid Parentheses
    //TC O(n2) SC O(n)
    public IList<string> RemoveInvalidParentheses(string s) 
    {
        var result = new List<string>();
        if (s == null) return result;
        var visited = new HashSet<string>();
        visited.Add(s);
        var queue = new Queue<string>();
        queue.Enqueue(s);
        while(queue.Any())
        {
            if(result.Count > 0) 
                break;
            int count = queue.Count;
            for(int cnt = 0; cnt < count; cnt++)
            {
                var current = queue.Dequeue();
                if(IsValidParentheses(current))
                    result.Add(current);
                for(int i = 0; i < current.Length; i++)
                {
                    if(current[i] == '('|| current[i] == ')')
                    {
                        var newString = current.Substring(0, i) +  current.Substring(i + 1);
                        if(!visited.Contains(newString))
                        {
                            queue.Enqueue(newString);
                            visited.Add(newString);
                        }
                    }
                }
            }
        }
        
        return result;
    }
    
    
    private bool IsValidParentheses(string s)
    {
        int open = 0, close = 0;
        foreach(var ch in s)
        {
            if(ch == '(')
                open++;
            else if(ch ==')')
                close++;
            if(close>open)
                return false;
        }
        
        return open == close;
    }
}