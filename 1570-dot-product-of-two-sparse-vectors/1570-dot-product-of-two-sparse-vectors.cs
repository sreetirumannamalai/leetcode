public class SparseVector {
    //Dot Product of Two Sparse Vectors
   //Let nn be the length of the input array and LL be the number of non-zero elements.
   //Time complexity: O(n)O(n) for creating the Hash Map; O(L)O(L) for calculating the dot product.
   //Space complexity: O(L)O(L) for creating the Hash Map, as we only store elements that are non-zero. O(1)O(1) for calculating the dot product.
    Dictionary<int ,int> indexAndValueDict = new Dictionary<int, int>();
    public SparseVector(int[] nums) {
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
                indexAndValueDict.Add(i, nums[i]);
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        int product = 0;
        foreach(var kv in indexAndValueDict)
        {
            if(vec.indexAndValueDict.ContainsKey(kv.Key))
            {
                product += indexAndValueDict[kv.Key] * vec.indexAndValueDict[kv.Key];
            }
        }
        return product;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);