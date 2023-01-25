namespace MyUtilities
{
    public static class ArrayUtils
    {
        public static int Length(string str)
        {
            return str.Length;
        }
        public static string ToUpper(string str)
        {
            string newStr = "";
            int len = Length(str);
            for ( int i = 0 ; i < len ; i++ )
            {
                char c = str[i];
                if ( c == 'a' )
                {
                    newStr += 'A';
                }
                else if (c == 'b' )
                {
                    newStr += 'B';
                }
                else if (c == 'c' )
                {
                    newStr += 'C';
                }
                else if (c == 'd' )
                {
                    newStr += 'D';
                }
                else if (c =='e' )
                {
                    newStr += 'E';
                }
                else if (c == 'f' )
                {
                    newStr += 'F';
                }
                else if (c == 'g')
                {
                    newStr += 'G';
                }
                else if (c == 'h')
                {
                    newStr += 'H';
                }
                else if (c == 'i')
                {
                    newStr += 'I';
                }
                else if (c == 'j')
                {
                    newStr += 'J';
                }
                else if (c == 'k')
                {
                    newStr += 'K';
                }
                else if (c == 'l')
                {
                    newStr += 'L';
                }
                else if (c == 'm')
                {
                    newStr += 'M';
                }
                else if (c == 'n')
                {
                    newStr += 'N';
                }
                else if (c == 'o')
                {
                    newStr += 'O';
                }
                else if (c == 'p')
                {
                    newStr += 'P';
                }
                else if (c == 'q')
                {
                    newStr += 'q';
                }
                else if (c == 'r')
                {
                     newStr += 'R';
                }
                else if (c == 's')
                {
                    newStr += 'S';
                }
                else if (c == 't')
                {
                    newStr += 'T';
                }
                else if (c == 'u')
                {
                    newStr += 'U';
                }
                else if (c == 'v')
                {
                    newStr += 'V';
                }
                else if (c == 'w')
                {
                    newStr += 'W';
                }
                else if (c == 'x')
                {
                    newStr += 'X';
                } 
                else if (c == 'y')
                {
                    newStr += 'Y';
                }
                else if (c == 'z')
                {
                    newStr+= 'Z';
                }
                else 
                {
                    newStr += c;
                }
            }
            return str;
        }
        
    }
}