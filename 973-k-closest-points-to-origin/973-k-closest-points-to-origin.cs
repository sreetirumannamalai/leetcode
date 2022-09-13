public class Solution {
    // K Closest Points to Origin
    //TC O(N) SC O(n)
    public int[][] KClosest(int[][] points, int k) {
        Dictionary<int,int> distances = new Dictionary<int, int>();
        //foreach point calculate the distance from origin and save it in dictionary
        //key is index of point array and d is its distance from origin
        for(int i =0;i<points.Length;i++)
        {
            int d = EuclideanDistanceFromOrigin(points[i][0], points[i][1]);
            distances.Add(i,d);
        }
        //sort dictionary by value (value is distance)
        var ordered = distances.OrderBy(x => x.Value);
        
        int[][] result = new int[k][];
        int l = 0;
        //take top K elements and add them in result array
        foreach(KeyValuePair<int,int> kvp in ordered.Take(k))
        {
            //from points array select coordinates
            result[l] = new [] { points[kvp.Key][0], points[kvp.Key][1]};
            l++;
        }
        return result;
    }
    
    public int EuclideanDistanceFromOrigin(int p1, int p2)
    {
        return ((p1*p1) + (p2*p2));
    }
}