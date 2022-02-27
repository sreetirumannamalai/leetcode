class Solution {
    Dictionary<int, List<int>> graph;
    bool[] visited;
    bool[] explored;
    Stack<int> stk;
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        graph = new Dictionary<int, List<int>>();
        for(int i = 0; i < numCourses; i++){
            graph.Add(i, new List<int>());
        }
        for(int i = 0; i < prerequisites.Length; i++){
            graph[prerequisites[i][1]].Add(prerequisites[i][0]);
        }
        
        explored = new bool[numCourses];
        visited = new bool[numCourses];
        
        for(int i = 0; i < numCourses; i++){
            if(!visited[i]){
                if(isCyclic(i)){
                    return new int[]{};
                }
            }
        }
        
        visited = new bool[numCourses];
        stk = new Stack<int>();
        for(int i = 0; i < numCourses; i++){
            if(!visited[i]){
                topologicalSort(i);
            }
        }
        
        int[] res = new int[stk.Count()];
        for(int i = 0; i < res.Length; i++){
            res[i] = stk.Pop();
        }
        
        return res;
    }
    
    public bool isCyclic(int i){
        visited[i] = true;
        foreach(int j in graph[i]){
            if(!visited[j]){
                if(isCyclic(j)){
                    return true;
                }
            }
            else if(!explored[j]){
                return true;
            }
        }
        explored[i] = true;
        return false;
    }
    
    public void topologicalSort(int i){
        visited[i] = true;
        foreach(int j in graph[i]){
            if(!visited[j]){
                topologicalSort(j);
            }
        }
        stk.Push(i);
    }
}