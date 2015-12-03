public class Solution {
    public bool IsPalindrome(string s) {
        int beginPtr = 0;
        int endPtr = s.Length - 1;

        int beginLetter = 0;
        int endLetter = 0;

        while (beginPtr < endPtr)
        {
            beginLetter = Char.ToUpper(s[beginPtr]);
            endLetter = Char.ToUpper(s[endPtr]);

            if (!isAlphaNumeric(beginLetter))
            {
                beginPtr++;
                continue;
            }

            if (!isAlphaNumeric(endLetter))
            {
                endPtr--;
                continue;
            }

            if (beginLetter != endLetter)
                return false;

            beginPtr++;
            endPtr--;
        }

        return true;
    }
    
    public static bool isAlphaNumeric(int letterCode)
    {
        return (48 <= letterCode && letterCode <= 57) || (65 <= letterCode && letterCode <= 90);
    }
}