public class Solution {
    public string Tictactoe(int[][] moves) {
        int diag1 = 0;
        int diag2 = 0;
        int[] row = new int[3];
        int[] col = new int[3];
        for(int i=0;i<moves.Length;i++)
        {
            int x = moves[i][0];
            int y = moves[i][1];
            var inc = i % 2 == 0 ? 1 : -1;
            row[x] += inc;
            col[y] += inc;
            if(x == y)
                diag1 += inc;
            
            if(x + y == 2) 
                diag2 += inc;
            
            if(Math.Abs(row[x]) == 3 || Math.Abs(col[y]) == 3 || Math.Abs(diag1) == 3 || Math.Abs(diag2) == 3)
                return i % 2 == 0 ? "A" : "B";
        }
        return moves.Length == 9 ? "Draw" : "Pending";
    }
}
 