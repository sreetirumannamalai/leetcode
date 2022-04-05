public class FreqStack {
   // O(1) sc O(n)
    private int maxFreq = 0;
    private Dictionary<int, int> freq; //number, occurence
    private Dictionary<int, Stack<int>> maxFreqs; //occurence, numbers
    
    public FreqStack() {
        freq = new Dictionary<int, int>();
        maxFreqs = new Dictionary<int, Stack<int>>();
    }
    
    public void Push(int val) {
        if(freq.ContainsKey(val))
            freq[val]++;
        else
            freq.Add(val, 1);
        
        maxFreq = Math.Max(maxFreq, freq[val]);
        
        if(maxFreqs.ContainsKey(freq[val]))
            maxFreqs[freq[val]].Push(val);
        else
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(val);
            maxFreqs.Add(freq[val], stack);
        }
    }
    
    public int Pop() {
        int res = maxFreqs[maxFreq].Pop();
        
        freq[res]--;
        
        if(maxFreqs[maxFreq].Count == 0)
            maxFreq--;
        
        return res;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */