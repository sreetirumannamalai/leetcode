public class Solution {
   public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            //corner case
            if (grid[0][0] == 1 || grid[row - 1][col - 1] == 1)
            {
                return -1;
            }
            bool[,] visited = new bool[row, col];
            visited[0, 0] = true;
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { 0, 0 });
            int[][] dirs = 
            {
                new int[] {1,0},
                new int[] {-1,0},
                new int[] {0,1},
                new int[] {0,-1},
                new int[] {1,1},
                new int[] {1,-1},
                new int[] {-1,1},
                new int[] {-1,-1}
           };
            int level = 1;
            while (queue.Count != 0)
            {
                //number of vertices in current level
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int[] node = queue.Dequeue();
                    //if true, we reach the bottom right node
                    if (node[0] == row - 1 && node[1] == col - 1)
                    {
                        return level;
                    }

                    //enumerate all neighbors
                    for (int j = 0; j < dirs.Length; j++)
                    {
                        int neighbor_x = dirs[j][0] + node[0];
                        int neighbor_y = dirs[j][1] + node[1];
                        //check whether the index is valid or not, and also whether the neighbor is already visited or not
                        if (neighbor_x >= 0 && neighbor_x < row &&
                           neighbor_y >= 0 && neighbor_y < col &&
                            !visited[neighbor_x, neighbor_y] &&
                            grid[neighbor_x][neighbor_y] == 0)
                        {
                            queue.Enqueue(new int[] { neighbor_x, neighbor_y });
                            visited[neighbor_x, neighbor_y] = true;
                        }
                    }
                }
                level++;
            }
            //no path found
            return -1;
        }
}