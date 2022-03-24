public class Solution {
    public int NumSimilarGroups(string[] strs) {
        int result = 0;
        if(strs.Length == 0 || strs == null)
            return 0;
        
        HashSet<string> visited = new HashSet<string>();
        foreach(string  s in strs)
        {
            if(!visited.Contains(s))
            {
                dfs(s, strs, visited);
                result++;
            }
        }
        return result;    
    }
    
    public void dfs(string s, string[] strs, HashSet<string> visited)
    {
        if(visited.Contains(s))
            return;
        
        visited.Add(s);
        
        for(int i=0;i<strs.Length;i++)
        {
            if(isSimilar(s, strs[i]))
                dfs(strs[i], strs, visited);
        }
    }
    
    public bool isSimilar(string s1, string s2)
    {
        int count =0;
        for(int i=0;i<s1.Length;i++)
        {
            if(s1[i] != s2[i])
            {
                count++;
                if(count > 2)
                {
                    return false;
                }
            }
        }
        return true;
    }
}