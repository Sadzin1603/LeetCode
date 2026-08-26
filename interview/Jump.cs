public class Jump {
    public bool CanJump(int[] nums) {
        int maiorAlcance=0;
        for(int i=0;i<nums.Length;i++){
            
            if(i > maiorAlcance){
                return false;
            }

            maiorAlcance = Math.Max(maiorAlcance,i+nums[i]);
            
            if(maiorAlcance >= nums.Length -1)
            {
                return true;
            }

        }
        return true;
    }
}