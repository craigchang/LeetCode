public class Solution {
    public void MoveZeroes(int[] nums) {
        int numLeadingZeroes = 0;

        for(int i = 0; i < nums.Length - numLeadingZeroes; i++)
        {
            while(nums[i] == 0)
            {
                for (int j = i; j < nums.Length - 1; j++)
                    nums[j] = nums[j + 1];
                nums[nums.Length - 1] = 0;

                numLeadingZeroes++;

                if (nums.Length - i == numLeadingZeroes)
                    break;
            }
        }
    }
}