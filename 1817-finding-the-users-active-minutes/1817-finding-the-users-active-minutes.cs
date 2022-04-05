public class Solution {
    //O(n) sc O(n)
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        int[] res = new int[k];
        if(logs.Length ==0 || logs == null)
            return res;
        
        Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
        for(int i=0;i<logs.Length;i++)
        {
            int user = logs[i][0];
            int time = logs[i][1];
            
            if(!dict.ContainsKey(user))
                dict[user] = new HashSet<int>(){time};
            else
                dict[user].Add(time);
        }
        
        foreach(KeyValuePair<int, HashSet<int>> kv in dict)
        {
            res[kv.Value.Count - 1]++;
        }
        return res;
    }
}