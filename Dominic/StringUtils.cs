namespace MyUtilities
{
    public static class StringUtils
    {
        public static int Length(string str)
        {
            return str.Length;
        }
        public static string ToUpper(string str)
        {
            string newStr = "";
            foreach( char letter in str )
            {
                if ( letter > '\u0061' && letter < '\u007A' )
                {
                    char newChar = (char)(str[letter] + 32);
                    newStr += newChar;
                }
            }
            return newStr;


            // string newStr = "";
            // char[] ltr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            // char[] utr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            // bool isLower = true;
            // foreach (char cr in str)
            // {
// 
                // foreach ( char lc in ltr )
                // {
                    // if ( lc == cr )
                    // {
                        // newStr += utr[lc];
                        // Console.WriteLine(newStr);
                    // }
                    // else
                    // {
                        // isLower = false;
                    // }
                // }
                // if (isLower == false)
                // {
                    // newStr += cr;
                    // isLower = true;
                // }
            // }
            // return str;
        }
        public static string ToLower(string str)
        {
            string newStr = "";
            int len = Length(str);
            char[] ltr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] utr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            bool isUpper = true;
            foreach (char cr in str)
            {
                foreach (char uc in utr)
                {
                    if (cr == uc )
                    {
                        newStr += ltr[uc]; 
                    }
                    else
                    isUpper = false;
                }
                if (isUpper == false)
                {
                    newStr += str[cr];
                    isUpper = true;
                }
            }
            return newStr;
        }
        public static string Reverse(string str)
        {
            int len = Length(str);
            string newStr = "";
            for ( int i = len - 1 ; i >= 0 ; i-- )
            {
                newStr += str[len - i];
            }
            return newStr;
        }
        public static bool HasLetter(string str, char ltr)
        {
            foreach (char cr in str)
            {
                if (cr == ltr)
                {
                    return true;
                }
            }
            return false;
        }
        public static int CountVowels(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'I', 'O', 'U', 'E' };
            int vowelCount = 0;
            foreach (char letter in word)
            {
                foreach (char vowel in vowels)
                {
                    if (letter == vowel)
                    {
                        vowelCount++;
                    }
                }
            }
            return vowelCount;
        }
        public static int CountConsonants(string word)
        {
            string consonants = "qwrtyplkjhgfdszxcvbnmQWSDFRTGHYKLPMNBVCXZJ";
            int consonantCount = 0;
            foreach (char letter in word)
            {
                foreach (char consonant in consonants)
                {
                    if (letter == consonant)
                    {
                        consonantCount++;
                    }
                }
            }
            return -1;
        }
    }
}