namespace MyUtilities
{
    public static class ArrayUtils
    {
        public static int Length(string str)
        {
            for ( int i = 0 ; str[i] != '' ; i++ )
            {
                return i;
            }
            return 0;
        }
    }
}