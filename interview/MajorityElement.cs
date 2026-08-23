public class MajorityElement{
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int, int> res = new Dictionary<int, int>();

        for(int i=0;i<nums.Length;i++)
        {
            if(res.ContainsKey(nums[i]))
            {
                res[nums[i]] +=1;
            }else
            {
                res.Add(nums[i],1);
            }
        }
        int maior = int.MinValue;
        int keyMaior=0;
        foreach(var item in res)
        {
            if (item.Value > maior)
            {
                maior = item.Value;
                keyMaior = item.Key;
            }
        }
        return keyMaior;
    }
}