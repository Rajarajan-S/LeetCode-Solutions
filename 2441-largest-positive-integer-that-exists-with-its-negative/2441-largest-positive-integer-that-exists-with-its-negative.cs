public class Solution {
    public int FindMaxK(int[] nums) {
        
        Array.Sort(nums);
        
        var num = -1;
        
        var dict = new Dictionary<int,int>();
        
        for(int i=0; i<nums.Length; i++){
            
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],nums[i]); 
            }
            if(nums[i] > 0 && dict.ContainsKey(-nums[i])){
                num = Math.Max(num,nums[i]);
            } 
        }
        return num;        
    }
}