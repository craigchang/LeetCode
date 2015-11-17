public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        KeyValuePair<int, int> majorityElement = new KeyValuePair<int, int>();
        int count = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int el = nums[i];

            if (!dict.ContainsKey(el))
                dict.Add(el, 1);
            else
                dict[el]++;
        }

        foreach (KeyValuePair<int, int> kvPair in dict)
        {
            if (kvPair.Value > count) {
                majorityElement = kvPair;
                count = kvPair.Value;
            }
        }

        return majorityElement.Key;
    }
}