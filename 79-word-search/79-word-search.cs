public class Solution {
    //O(4 * n) = O(n), sc O(1)
     public bool Exist(char[][] board, string word)
        {
            int row = board.Length;
            int col = board[0].Length;
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    if (board[i][j] == word[0] && WordSearch(board, i, j, word, 0))
                        return true;
                }
            }
            return false;
        }

        public bool WordSearch(char[][] board, int i, int j, string word, int index)
        {
            if (index == word.Length - 1)
                return true;

            board[i][j] -= (char)65; // O(1) operation // change to any other char outside of A-Z and a-z

            if (i > 0 && board[i - 1][j] == word[index + 1] && WordSearch(board, i - 1, j, word, index + 1))
                return true;

            if (j > 0 && board[i][j - 1] == word[index + 1] && WordSearch(board, i, j - 1, word, index + 1))
                return true;

            if (i < board.Length - 1 && board[i + 1][j] == word[index + 1] && WordSearch(board, i + 1, j, word, index + 1))
                return true;
            if (j < board[0].Length - 1 && board[i][j + 1] == word[index + 1] && WordSearch(board, i, j + 1, word, index + 1))
                return true;

            board[i][j] += (char)65; //change the char back to original char to backtrack again

            return false;
        }
}