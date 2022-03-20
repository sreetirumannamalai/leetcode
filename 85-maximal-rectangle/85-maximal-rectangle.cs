public class Solution {
    public int MaximalRectangle(char[][] matrix) {
      if(matrix.Length == 0) return 0;
   
      int maxArea = 0;
      int[] dp = new int[matrix[0].Length];
        
      for(int i=0;i< matrix.GetLength(0);i++)
      {
        for(int j=0;j<matrix[i].Length;j++)
        {
            if(matrix[i][j] != '0')
            {
                int minHeight = int.MaxValue;
                dp[j] += Convert.ToInt16(matrix[i][j] - '0');
            
                for(int k = j ; k>=0 && matrix[i][k] > 0; k--)
                {
                    minHeight = Math.Min(minHeight, dp[k]);
                    maxArea = Math.Max(maxArea, minHeight * (j - k + 1));
                }
            }
            else
                dp[j] = 0;
        }
      }
        return maxArea;
    }
}
  