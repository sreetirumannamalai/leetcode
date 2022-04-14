public class Solution {
    public int CountComponents(int n, int[][] edges) {
        if(edges.Length == 0) return n;
        
        bool[] visited = new bool[n];
        //Build Adjacency List
        List<List<int>> adjList = BuildAdjList(n, edges);
        int noOfComponents = 0;
        
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                dfs(i, visited, adjList);
                noOfComponents++;
            }
        }
        return noOfComponents;
    }
    
    public void dfs(int i, bool[] visited, List<List<int>> adjList)
    {
        visited[i] = true;
        List<int> neighbors = adjList[i];
        foreach(int neigh in neighbors)
        {
            if(!visited[neigh])
                dfs(neigh, visited, adjList);
        }
    }
    
    public List<List<int>> BuildAdjList(int n, int[][] edges)
    {
        List<List<int>> adjList = new List<List<int>>();
        for(int i=0;i<n;i++)
        {
            adjList.Add(new List<int>());
        }
        
        for(int i =0;i<edges.Length;i++)
        {
            adjList[edges[i][0]].Add(edges[i][1]);
            adjList[edges[i][1]].Add(edges[i][0]);
        }
        return adjList;
    }
}