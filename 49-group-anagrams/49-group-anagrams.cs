public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if(strs == null || strs.Length == 0) return null;
        
        List<IList<string>> result = new List<IList<string>>();
        
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
        
        /*string[] removeDups = new string[strs.Length];
        for(int i=0;i<strs.Length;i++)
        {
            removeDups[i] = RemoveDuplicateLetters(strs[i]);
        }
        */
        foreach(string str in strs)
        {
            int[] freq = new int[26];
            foreach(char c in str)
            {
                freq[c-'a']++;
            }
            
            string key = string.Join('-',freq);
            
            if(dict.ContainsKey(key))
            {
                dict[key].Add(str);
            }
            else
                dict.Add(key, new List<string>{str});
        }
        return dict.Values.ToList();
    }
    
    //Remove Duplicate Letters
        public string RemoveDuplicateLetters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            var count = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
            }
            var sb = new StringBuilder();
            var hs = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']--;
                if (hs.Contains(s[i]))
                    continue;
                while (sb.Length > 0 && sb[sb.Length - 1] > s[i] && count[sb[sb.Length - 1] - 'a'] > 0)
                {
                    hs.Remove(sb[sb.Length - 1]);
                    sb.Length--;
                }
                hs.Add(s[i]);
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
}