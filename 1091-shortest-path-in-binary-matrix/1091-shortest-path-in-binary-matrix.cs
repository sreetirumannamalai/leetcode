public class Solution {
    //Shortest Path in Binary Matrix
    //TC O(n) SC O(n)
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if(grid.Length == 0) return -1;
        
        int row = grid.Length;
        int col = grid[0].Length;
        
        if(grid[0][0] == 1 || grid[row-1][col-1] == 1)
            return -1;

        Queue<int[]> q = new Queue<int[]>();
        q.Enqueue(new int[]{0,0});
        bool[,] visited = new bool[row,col];
        visited[0,0] = true;
        int level = 1;
        
        int[][] directions = {
            new int[] {1,0},
            new int[] {-1,0},
            new int[] {1,1},
            new int[] {1,-1},
            new int[] {-1,1},
            new int[] {-1,-1},
            new int[] {0,1},
            new int[] {0,-1}
        };
        while(q.Count != 0)
        {
            int size = q.Count;
            for(int i= 0;i<size;i++)
            {
                int[] node = q.Dequeue();
                if(node[0] == row -1 && node[1] == col -1)
                {
                    return level;
                }
                
                for(int j =0;j<directions.Length ;j++)
                {
                    int neighbor_x = directions[j][0] + node[0];
                    int neighbor_y = directions[j][1] + node[1];
                    
                    if(neighbor_x >= 0 && neighbor_x < row &&
                       neighbor_y >= 0 && neighbor_y < col &&
                       grid[neighbor_x][neighbor_y] == 0 && !visited[neighbor_x , neighbor_y])
                    {
                        q.Enqueue(new int[]{neighbor_x, neighbor_y});
                        visited[neighbor_x, neighbor_y] = true;
                    }
                }
            }
            level++;
        }
        return -1;
    }
}