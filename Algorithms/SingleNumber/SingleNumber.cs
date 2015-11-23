public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
                dict[nums[i]] = 1;
            else
                dict[nums[i]]++;
        }
        
        return dict.FirstOrDefault(x => x.Value == 1).Key;
    }
}