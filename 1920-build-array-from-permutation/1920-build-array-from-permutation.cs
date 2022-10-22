public class Solution {
    public int[] BuildArray(int[] nums) {
        int n = nums.Length;
        int [] res = new int[n];
        for (int i = 0; i < n; i++){            
            res[i] = nums[nums[i]];
        }
        return res;
    }
}