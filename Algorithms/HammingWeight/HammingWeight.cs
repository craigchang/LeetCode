public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        while (n > 0)
        {
            if ((1 & n) == 1)
                count++;
            n >>= 1;
        }
        return count;
    }
}