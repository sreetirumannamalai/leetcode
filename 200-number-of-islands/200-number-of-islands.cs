public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid.Length == 0) return 0;
        int islandCount = 0;
        int m = grid.Length;
        int n = grid[0].Length;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j] == '1')
                {
                    DFS(i, j, m, n, grid);
                    islandCount++;
                }
            }
        }
        return islandCount;
    }
    
    public void DFS(int i, int j, int m, int n, char[][] grid)
    {
        if(i < 0 || j < 0 || i >= m || j >= n || grid[i][j] == '0')
            return ;
        
        grid[i][j] = '0';
        
        DFS(i+1, j, m, n, grid);
        DFS(i-1, j, m, n, grid);
        DFS(i, j+1, m, n, grid);
        DFS(i, j-1, m, n, grid);
    }
}