public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        int soma=1;
        for(int i=0;i<nums.Length;i++)
        {
            if(i==0){
                answer[i] = 1;
            }
            else
            {
                soma *= nums[i-1];
                answer[i] = soma;
            }
            
        }
        soma =1;
        for(int i=nums.Length-1;i>=0;i--)
        {
            if(i==nums.Length-1)
            {
                answer[i] *= 1;
            }
            else
            {
                soma *= nums[i+1];
                answer[i] *= soma;
            }
        }
        
        return answer;
    }
}