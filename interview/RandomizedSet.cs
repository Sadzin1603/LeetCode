public class RandomizedSet {
    private List<int> Lista = new List<int>();
    public RandomizedSet() {
        
    }
    
    public bool Insert(int val) {
        if (Lista.Contains(val))
        {
            return false;
        }
        Lista.Add(val);
        return true;    
    }
    
    public bool Remove(int val) {
        if (!Lista.Contains(val))
        {
            return false;
        }

        Lista.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        int numero = Random.Shared.Next(0, Lista.Count());

        return Lista.ElementAt(numero);
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */