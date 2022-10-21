public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        Dictionary <int, int> numsDict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++){
            
            if (numsDict.ContainsKey(nums[i])) return true;
            else numsDict.Add(nums[i], 1);
        }
        return false;
    }
}