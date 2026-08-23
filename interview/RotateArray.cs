public class RotateArray
{
    public void Rotate(int[] nums, int k) 
    {      
        k = k % nums.Length;
        invert(nums,0,nums.Length-1);
        invert(nums,0,k-1);
        invert(nums,k,nums.Length-1);
        
    }
    public void invert(int[] nums,int inicio,int fim)
    {
        int aux;
        while(inicio<fim){
            aux = nums[inicio];
            nums[inicio] = nums[fim];
            nums[fim] = aux;
            inicio++;
            fim--;
        }
    }
    
}