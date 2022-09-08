public class Solution {
      //Kth Largest Element in an Array using Quick Select
        //TC O(n)in average case O(n2) in worst case SC O(1)
       
     public int FindKthLargest(int[] arr, int k) {
          int low = 0;
        int high = arr.Length - 1;
         int n = arr.Length ;
         int pivot = FindKthLargest(arr, n-k, low, high);
         return pivot;
     }
    
    public int FindKthLargest(int[] arr, int k, int low, int high) {
        int pivotPoint = getPivotPoint(arr,low,high);
        if(pivotPoint == k) return arr[pivotPoint];
        else if(pivotPoint < k) return FindKthLargest(arr,k,pivotPoint + 1,high);
            //4,5,10,11,1,3,19,8,7
            // 4 5 1 3 7 10 11 19 8
        else return FindKthLargest(arr,k,low,pivotPoint -1);
    }

    private int getPivotPoint(int[] arr, int low, int high) {
        int pivotElement = arr[high];
        int pivotPoint = low;

        for(int i= low;i<=high;i++){
            if(arr[i] < pivotElement){
                int tmp = arr[i];
                arr[i] = arr[pivotPoint];
                arr[pivotPoint] = tmp;
                pivotPoint++;
            }
            //4,5,10,11,1,3,19,8,7
            //4 5 1 11 10 3 19 8 7
            // 4 5 1 3 10 11 19 8 7
            //pivotPoint =5
            //i=5

        }
        int temp = arr[pivotPoint];
        arr[pivotPoint] = arr[high];
        arr[high] = temp;

        return pivotPoint;
    }
}