public class FreqStack {
    //O(1) sc O(n)
    private int maxFreq = 0;
    private Dictionary<int, int> freq; //number, occurrence
    private Dictionary<int, Stack<int>> maxFreqs;// occurrence, numbers
    
    public FreqStack() {
        freq = new Dictionary<int, int>();
        maxFreqs = new Dictionary<int, Stack<int>>();
    }
    
   public void Push(int x) {
        if(freq.ContainsKey(x))
            freq[x]++;
        else
            freq.Add(x,1);
        
        maxFreq = Math.Max(maxFreq, freq[x]);
        
        if(maxFreqs.ContainsKey(freq[x]))
            maxFreqs[freq[x]].Push(x);
        else
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(x);
            maxFreqs.Add(freq[x], stack);
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
 