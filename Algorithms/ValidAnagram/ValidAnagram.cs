public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        char[] charArr1 = s.ToCharArray();
        char[] charArr2 = t.ToCharArray();
        Array.Sort(charArr1);
        Array.Sort(charArr2);
        return String.Join("", charArr1) == String.Join("", charArr2);
    }
}