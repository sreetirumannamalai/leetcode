public class Solution {
    //O(n) sc O(1)
    public int LeastInterval(char[] tasks, int n) {
        int maxFreq = 0;
        int interval = 0;
        int cnt = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        //Find the max frequency that any task can have
        foreach(char t in tasks)
        {
            if(dict.ContainsKey(t))
                dict[t]++;
            else
                dict.Add(t,1);
            
            
            maxFreq = Math.Max(maxFreq, dict[t]);
        }
        //Find the number of tasks that have the max frequency
        foreach(var kv in dict)
        {
            if(dict[kv.Key] == maxFreq)
                cnt++;
        }
        
        interval = (maxFreq - 1) * (n+1) + cnt;
        return interval < tasks.Length ? tasks.Length : interval;
    }
}