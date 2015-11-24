public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int newLength = 0;
        
        for(int i = 0; i < nums.Length; i++){
            if (nums[i] != val){
                nums[newLength++] = nums[i];
            }
        }
        
        return newLength;
    }
}
