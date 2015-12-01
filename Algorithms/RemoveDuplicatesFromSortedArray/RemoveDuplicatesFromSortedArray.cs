public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int n = 0;
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i+1])
            {
                nums[++n] = nums[i+1];
            }
        }
        
        return n+1;
    }
}