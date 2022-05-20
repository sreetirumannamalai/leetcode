public class Solution {
    public int MinDeletions(string s) {
        if(s.Length == 0 || s == null) return 0;
        
        Dictionary<char,int> dict = new Dictionary<char, int>();
        foreach(char c in s)
        {
            if(!dict.ContainsKey(c))
            {
                dict.Add(c,1);
            }
            else
            {
                dict[c]++;
            }
        }
        
        int result = 0;
        HashSet<int> set = new HashSet<int>();
        foreach(var kv in dict)
        {
            int val = dict[kv.Key];
            while(set.Contains(val) && val > 0)
            {
                val--;
                result++;
            }
            set.Add(val);
        }
        return result;
    }
}
