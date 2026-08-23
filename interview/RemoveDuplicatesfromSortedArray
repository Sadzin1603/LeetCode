import java.util.*;
public class RemoveDuplicatesfromSortedArray {
    public int removeDuplicates(int[] nums) {
        HashMap<Integer, Integer> num = new HashMap<>();
        int qtd=0;
        for(int i=0;i<nums.length;i++){
            if(!num.containsKey(nums[i])){
                num.put(Integer.valueOf(nums[i]),Integer.valueOf(nums[i]));
                nums[qtd] = nums[i];
                qtd++;
            }
            
        }
        return qtd;
    }
}