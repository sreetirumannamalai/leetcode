public class Solution {
      //Kth Largest Element in an Array using Quick Select
      //TC O(n)in average case O(n2) in worst case SC O(1)
      public int FindKthLargest(int[] arr, int k)
      {
          int i = 0;
          int j = arr.Length - 1;
          int n = arr.Length;
          
         int result = FindKthLargest(arr, n-k, i, j);
         return result;
      }

    public int FindKthLargest(int[] arr, int k, int low, int high)
    {
        int pivotPoint = GetPivotPoint(arr, low, high);
        if(pivotPoint == k)
            return arr[pivotPoint];
        else if(pivotPoint < k)
            return FindKthLargest(arr, k, pivotPoint + 1, high);
        else
            return FindKthLargest(arr, k, low, pivotPoint - 1);
    }
    
    public int GetPivotPoint(int[] arr, int low, int high)
    {
        int pivotElement = arr[high];
        int pivotPoint = low;
        for(int i= low;i<=high;i++)
        {
            if(arr[i] < pivotElement)
            {
                 int temp = arr[i];
                 arr[i] = arr[pivotPoint];
                 arr[pivotPoint] = temp;
                 pivotPoint++;
            }
        }
        int tmp = arr[pivotPoint];
        arr[pivotPoint] = arr[high];
        arr[high] = tmp;
        return pivotPoint;
    }
}