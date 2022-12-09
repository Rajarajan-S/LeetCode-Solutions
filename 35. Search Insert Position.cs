public class Solution {
public int SearchInsert(int[] nums, int target) {

    for(int i=0; i<nums.Length; i++){
        
        if(nums[i] == target)
        {
            return i;
        }
        else if(nums[i]-1 == target)
        {
          
           return i;
         
        }
        else if(nums[i] + 1 == target)
        {
          
            return i+1;
        }
    }
    
     if(target<=1)
         {
              return 0;
         }
   
 return nums.Length;
}
}
