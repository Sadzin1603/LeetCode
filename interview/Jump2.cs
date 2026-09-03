public class Solution {
    public int Jump(int[] nums) {
        int Jumps=0;
        int CurrentEnd=0;
        int MaisLonge=0;

        for(int i = 0; i < nums.Length-1; i++)
        {
            MaisLonge = Math.Max(i+nums[i],MaisLonge);
            if (i == CurrentEnd)
            {
                CurrentEnd=MaisLonge;
                Jumps++;
            }
            

        }

        return Jumps;
    }
}