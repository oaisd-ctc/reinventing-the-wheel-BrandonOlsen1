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
            string newStr = " ";
            int len = Length(str);
            char[] ltr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] utr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            foreach (char cr in str)
            {
                foreach ( char lc in ltr )
                {
                    if ( lc == cr )
                    {
                        newStr += utr[lc];
                    }
                    else 
                    {
                        newStr += str[lc];
                    }
                }
            }
            return str;
        }
        public static string ToLower(string str)
        {
            string newStr = "";
            int len = Length(str);
            char[] ltr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] utr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            foreach (char cr in str)
            {
                foreach (char uc in utr)
                {
                    if (cr == uc )
                    {
                        newStr += ltr[uc]; 
                    }
                    else
                    {
                        newStr += str[cr];
                    }
                }
            }
            return newStr;
        }
    }
}