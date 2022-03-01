public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] matrix = new int[n][];
        for(int i=0;i<n;i++)
        {
            matrix[i] = new int[n];
        }

        int top = 0;// rowBegin = 0;
        int bottom =n-1; // rowEnd = n-1;
        int left = 0; //colBegin = 0;
        int right =n-1; // colEnd = n-1;
        int counter = 1;
        while(top <= bottom && left <= right)
        {
            for(int i = left;i<=right;i++)
            {
                matrix[top][i] = counter++;
            }
            top++;
            for(int i  =top;i<=bottom;i++)
            {
                matrix[i][right]= counter++;
            }
            right--;
            
            if(top <= bottom)
            {
                for(int i = right; i>= left;i--)
                {
                    matrix[bottom][i] = counter++;
                }
            }
            bottom--;
            
            if(left <= right)
            {
                for(int i= bottom; i>= top;i--)
                {
                    matrix[i][left] = counter++;
                }
            }
            left++;
        }
        return matrix;
    }
}