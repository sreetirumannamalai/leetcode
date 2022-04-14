public class Solution {
    //O(m * n) sc O(m * n)
    public int NumIslands(char[][] grid) {
        if(grid.Length == 0)
            return 0;
        int numOfIslands = 0;
        int m = grid.Length;
        int n = grid[0].Length;
        for(int i =0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j] == '1')
                {
                    DFS(i, j, grid, m, n);
                    numOfIslands++;
                }
            }
        }
         
        return numOfIslands;
    }
    
    public void DFS(int i, int j, char[][] grid, int m, int n)
    {
        if(i < 0 || j < 0 || i >= m || j >= n || grid[i][j] == '0')
            return;
        
         grid[i][j] = '0';
        
         DFS(i+1, j, grid, m, n);
         DFS(i-1, j, grid, m, n);
         DFS(i, j+1, grid, m, n);
         DFS(i, j-1, grid, m, n);
    }
}
 