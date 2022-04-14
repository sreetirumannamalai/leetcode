public class Solution {
    //O(N+E) sc O(N+E)
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length != n - 1) return false;
        
        HashSet<int> visited = new HashSet<int>();
        
        List<List<int>> adjList = BuildAdjList(n, edges);
        
        DFS(adjList, visited, 0);
        return visited.Count == n;
    }
    
    public List<List<int>> BuildAdjList(int n, int[][] edges)
    {
        List<List<int>> adjList = new List<List<int>>();
        for(int i=0;i<n;i++)
        {
            adjList.Add(new List<int>());
        }
        
        for(int i=0;i<edges.Length;i++)
        {
            adjList[edges[i][0]].Add(edges[i][1]);
            adjList[edges[i][1]].Add(edges[i][0]);
        }
        return adjList;
    }
    
    public void DFS(List<List<int>> adjList, HashSet<int> visited, int source)
    {
        if(visited.Contains(source))
            return;
        
        visited.Add(source);
        foreach(var neigh in adjList[source])
        {
            if(!visited.Contains(neigh))
                DFS(adjList, visited, neigh);
        }
        
    }
}
   