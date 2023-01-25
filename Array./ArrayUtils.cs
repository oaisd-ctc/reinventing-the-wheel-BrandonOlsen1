public static class ArrayUtils
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5};
        foreach (int n in Reverse(array))
        {
            Console.Write($"{n} ");
        }
    }
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
    public static int[] SortAscending(int[] nums)
    {
        int temp;
        // int[] newArray = new int[nums.Length];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
    public static double[] SortAscending(double[] nums)
    {
        double temp;
        // int[] newArray = new int[nums.Length];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
    public static int[] SortDecending(int[] nums)
    {
        int temp;
        // int[] newArray = new int[nums.Length];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
    public static double[] SortDecending(double[] nums)
    {
        double temp;
        // int[] newArray = new int[nums.Length];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
    public static int Sum(int[] nums)
    {
        int total = 0;
        foreach (int n in nums)
        {
            total += n;
        }
        return total;
    }
    public static double Sum(double[] nums)
    {
        double total = 0;
        foreach (double n in nums)
        {
            total += n;
        }
        return total;
    }
    public static int Product(int[] nums)
    {
        int total = 1;
        foreach (int n in nums)
        {
            total *= n;
        }
        return total;
    }
    public static double Product(double[] nums)
    {
        double total = 1;
        foreach (double n in nums)
        {
            total *= n;
        }
        return total;
    }
    public static int[] Reverse(int[] nums)
    {
        int[] newArray = new int[nums.Length];
        
        int array = nums.Length -1;
        int rev = nums.Length - nums.Length;
        while (array >= 0)
        {
            nums[array] = newArray[rev];
            if (array != 0)
            {
                array--;
                rev++;
            }
            
        }
        
        

        return newArray;
    }
}
