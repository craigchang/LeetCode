public class Solution {
    public int StrStr(string haystack, string needle) {
        int haystackLength = haystack.Length;
        int needleLength = needle.Length;
        string substr = "";
        
        for(int i = 0; i <= haystackLength - needleLength; i++)
        {
            substr = haystack.Substring(i, needleLength);
            if (substr == needle) return i;
        }
        
        return -1;
    }
}