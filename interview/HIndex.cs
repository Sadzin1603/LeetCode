public class HIndex {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);
        for(int i = 0; i < citations.Length; i++)
        {
            if (citations[i] < i+1)
            {
                return i;
            }
        }
        return citations.Length;
    }
}