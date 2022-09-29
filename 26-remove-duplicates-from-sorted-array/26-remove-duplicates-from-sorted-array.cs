public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = nums.Length, i, j;
        for( i = 1, j = 0; i < l; i++){
            if(nums[i] != nums[j]){
                j++;
                nums[j] = nums[i];                
            }        
        }
        return j+1;
    }
}