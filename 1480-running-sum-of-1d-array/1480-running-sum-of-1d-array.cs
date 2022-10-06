public class Solution {
    public int[] RunningSum(int[] nums) {
        int sum = 0,i;
        for(i=0; i < nums.Length; i++){
            nums[i] += sum;
            sum = nums[i];
        }
        return nums;
    }
}