public class Solution {
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        
        List<IList<string>> res = new List<IList<string>>();
        if(accounts == null || accounts.Count == 0)
            return res;
        
        // graph: <email, neighour emails>
        Dictionary<string,HashSet<string>> graph = new Dictionary<string,HashSet<string>>(); 
        Dictionary<string,string> emailNameDic = new Dictionary<string,string>();
        
        foreach(var accountList in accounts)
        {
            int size = accountList.Count;
            string accountName = accountList[0];
            
            for(int i = 1; i < size; i++)
            {
                if(!graph.ContainsKey(accountList[i]))
                    graph[accountList[i]] = new HashSet<string>();
                
                if(!emailNameDic.ContainsKey(accountList[i]))
                    emailNameDic.Add(accountList[i], accountName);
                
                if(i == 1)
                    continue;
                
                graph[accountList[i]].Add(accountList[i-1]);
                graph[accountList[i-1]].Add(accountList[i]);
            }
        }
        
        HashSet<string> visited = new HashSet<string>();
        foreach(var email in emailNameDic.Keys)
        {
            List<string> list = new List<string>();
            if(!visited.Contains(email))
            {
                dfs(graph, email, list, visited);
				// peform a lexical sort based on ASCII
                list.Sort(StringComparer.Ordinal);
                list.Insert(0, emailNameDic[email]);
                res.Add(list);
            }
        }
        
        return res;
    }
    
    private void dfs(Dictionary<string,HashSet<string>> graph, string email, List<string> list, HashSet<string> visited)
    {
        list.Add(email);
        visited.Add(email);
        foreach(var nextEmail in graph[email])
        {
            if(!visited.Contains(nextEmail))
                dfs(graph, nextEmail, list, visited);
        }
    }
}