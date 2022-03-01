public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //O(n * K) sc = O(n*k)
        List<IList<string>> result = new List<IList<string>>();
        if(strs.Length == 0 || strs == null)
            return result;
        
        Dictionary<string , IList<string>> dict = new Dictionary<string, IList<string>>();
        foreach(string str in strs)
        {
            int[] freq = new int[26];
            foreach(var c in str)
            {
                freq[c-'a']++;
            }
            string key = string.Join("-", freq);
            if(dict.ContainsKey(key))
            {
                dict[key].Add(str);
            }
            else
                dict.Add(key, new List<string>(){str});
        }
        return dict.Values.ToList();
    }
}

 