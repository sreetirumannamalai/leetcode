public class Solution {
    //O(n)
    public int LengthOfLongestSubstring(string s) {
      int n = s.Length;
        if(s.Length == 0 || s == null) return 0;
        
        HashSet<char> set = new HashSet<char>();
        int i =0;
        int j =0;
        int max =0;
        while(i<n)
        {
            char c = s[i];
            while(set.Contains(c))
            {
                set.Remove(s[j]);
                j++;
            }
            set.Add(c);
            max = Math.Max(max, i - j + 1);
            i++;
        }
        return max;
    }
}