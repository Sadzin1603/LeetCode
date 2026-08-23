public class RemoveDuplicatesfromSortedArrayII
{
    public int RemoveDuplicates(int[] nums) {
        Dictionary<int,int> res = new Dictionary<int,int>();
        int[] array = new int[nums.Length];
        int qtd=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(res.ContainsKey(nums[i]))
            {
                if(res[nums[i]] <2)
                {
                    res[nums[i]] +=1;
                    array[qtd] = nums[i];
                    qtd++;
                }
                
            }else
            {
                res.Add(nums[i],1);
                array[qtd] = nums[i];
                qtd++;
            }
            
        }
        for(int i=0;i<nums.Length;i++){
            nums[i] = array[i];
        }
        return qtd;
    }
}