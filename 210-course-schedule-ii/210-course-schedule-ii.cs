public class Solution {
    Dictionary<int, List<int>> graph;
    bool[] visited;
    bool[] explored;
    Stack<int> stack;
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        graph = new Dictionary<int, List<int>>();
        visited = new bool[numCourses];
        explored = new bool[numCourses];
        stack = new Stack<int>();
        
        for(int i=0;i<numCourses;i++)
        {
            graph.Add(i, new List<int>());
        }
        
        for(int i=0;i<prerequisites.Length;i++)
        {
            graph[prerequisites[i][1]].Add(prerequisites[i][0]);
        }
        
        for(int i=0;i<numCourses;i++)
        {
            if(!visited[i])
            {
                if(hasCycle(i))
                {
                    return new int[]{};
                }
            }
        }
        
        visited = new bool[numCourses];
        
        for(int i=0;i<numCourses;i++)
        {
            if(!visited[i])
            {
                topologicalSort(i);
            }
        }
        
        int[] result = new int[stack.Count];
        for(int i=0;i<result.Length;i++)
        {
            result[i] = stack.Pop();
        }
        return result;
    }
    
    public bool hasCycle(int i)
    {
        visited[i] = true;
        foreach(int neighbor in graph[i])
        {
            if(!visited[neighbor])
            {
                if(hasCycle(neighbor))
                    return true;
            }
            else if(!explored[neighbor])
                return true;
        }
        explored[i] = true;
        return false;
    }
    
    public void topologicalSort(int i)
    {
        visited[i] = true;
        foreach(int neighbor in graph[i])
        {
            if(!visited[neighbor])
                topologicalSort(neighbor);
        }
        stack.Push(i);
    }
}