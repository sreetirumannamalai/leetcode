public class RandomizedSet {
    //O(1) sc O(n)
    HashSet<int> set;
    List<int> list;
    Random random;
    public RandomizedSet() {
        random = new Random();
        set = new HashSet<int>();
        list = new List<int>();
    }
    
    public bool Insert(int val) {
        if(set.Contains(val))
            return false;
        else 
        {
            set.Add(val);
            list.Add(val);
        }
        return true;
    }
    
    public bool Remove(int val) {
        if(set.Contains(val))
        {
            set.Remove(val);
            list.Remove(val);
            return true;
        }
        return false;
    }
    
    public int GetRandom() {
        return list[random.Next(list.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */