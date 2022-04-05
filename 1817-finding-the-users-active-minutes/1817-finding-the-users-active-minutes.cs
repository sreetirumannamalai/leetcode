public class Solution {
    //O(n) sc O(n)
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        
        int[] res = new int[k];
        if(logs == null || logs.Length == 0)
            return res;
        
        Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>();
        for(int i = 0; i < logs.Length; i++)
        {
            int user = logs[i][0];
            int time = logs[i][1];
            
            if(!dic.ContainsKey(user))
                dic[user] = new HashSet<int>(){time};
            else
                dic[user].Add(time);
        }
        
        foreach(var kv in dic)
        {
            res[kv.Value.Count - 1]++;
        }
        
        return res;
    }
}