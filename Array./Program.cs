public static class ArrayUtils
{
    public static int Average(int[] nums)
    {
        int total = 0;
        foreach (int n in nums)
        {
            total += n;
        }
        return total / nums.Length;
    }
    public static double Average(double[] nums)
    {
        double total = 0;
        foreach (double n in nums)
        {
            total += n;
        }
        return total / nums.Length;
    }
    public static int Max(int[] nums)
    {
        int total = 0;
        foreach (int n in nums)
        {
            if (n > total)
            {
                total = n;
            }
        }
        return total;
    }
    public static double Max(double[] nums)
    {
        double total = 0;
        foreach (double n in nums)
        {
            if (n > total)
            {
                total = n;
            }
        }
        return total;
    }
    public static int Min(int[] nums)
    {
        int total = 0;
        foreach (int n in nums)
        {
            if (n < total)
            {
                total = n;
            }
        }
        return total;
    }
    public static double Min(double[] nums)
    {
        double total = 0;
        foreach (double n in nums)
        {
            if (n < total)
            {
                total = n;
            }
        }
        return total;
    }
}
