public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        //Count of frequency of each word
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for(int i=0;i<words.Length;i++)
        {
            if(!dict.ContainsKey(words[i]))
                dict.Add(words[i], 1);
            else
                dict[words[i]]++;
        }
        //Sort by frequency first
        //if same frequency, sort by key
        List<KeyValuePair<string, int>> test = dict.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).Take(k).ToList();
        
        //return top K keys from dict
        return test.Select(x=>x.Key).ToList();
    }
}