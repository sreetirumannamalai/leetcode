public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(numCourses == 0) return false;
        int[] visited = new int[numCourses];
        Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
        for(int i=0;i<numCourses;i++)
        {
            adjList.Add(i, new List<int>());
        }
        
        for(int i=0;i<prerequisites.Length;i++)
        {
            adjList[prerequisites[i][0]].Add(prerequisites[i][1]);
        }
        
        for(int i=0;i<numCourses;i++)
        {
            if(visited[i] == 0)
            {
                if(hasCycle(i, adjList, visited))
                {
                    return false;
                }
            }
        }
        return true;
    }
    
    public bool hasCycle(int i, Dictionary<int, List<int>> adjList, int[] visited)
    {
        visited[i] = 1;
        if(adjList.ContainsKey(i))
        {
            foreach(int neighbor in adjList[i])
            {
                if(visited[neighbor] == 0 && hasCycle(neighbor, adjList, visited) || visited[neighbor] == 1)
                {
                    return true;
                }
            }
        }
        visited[i] = 2;
        return false;
    }
}