public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int[] temp = (int[])nums.Clone();
        int index = 0;
        
        k = k % n;
        
        for(int i = n-k; i < n; i++)
            nums[index++] = nums[i];
        
        for(int i = 0; i < n-k; i++)
            nums[index++] = temp[i];
    }
}