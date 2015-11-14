public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        int digitAmt = 0;
        char[] chars = s.ToCharArray();

        for(int i = 0; i < chars.Length; i++)
        {
            digitAmt = RomanDigitToInt(chars[i]);

            if (i < chars.Length - 1 && RomanDigitToInt(chars[i + 1]) > RomanDigitToInt(chars[i]))
                digitAmt = -1 * RomanDigitToInt(chars[i]);
            
            result += digitAmt;
        }

        return result;
    }
    
    private int RomanDigitToInt(char c)
    {
        switch(c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
        }

        return 0;
    }
}