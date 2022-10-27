public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        
        int [] op = new int[2*n];
        
        for (int i = 0; i < nums.Length-n; i++){
            op[2*i] = nums[i];
            op[2* i+1] = nums[i+n];
        }
        return op;
    }
}