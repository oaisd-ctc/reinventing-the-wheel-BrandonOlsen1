namespace MyUtilities
{
    public static class ArrayUtils
    {
        // gets the average of all elements of an array
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
        // gets the index of the maximum number of an array
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
        // gets the index of the minimum number of an array
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
        // sorts the array so where the minimum number is index 0 and the maximum number is the last index
        public static int[] SortAscending(int[] nums)
        {
            int temp;
            
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
        // sorts the array so where the maximum number is index 0 and the minimum number is the last index
        public static int[] SortDecending(int[] nums)
        {
            int temp;
            
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
        // adds all the elements of an array together
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
        // multiplies all the elements together 
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
        // reverses the order of the array
        public static int[] Reverse(int[] nums)
        {
            int[] revArray = new int[nums.Length];

            int array = nums.Length - 1;
            int rev = nums.Length - nums.Length;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                revArray[rev] = nums[array];
                if (array != 0)
                {
                    array--;
                    rev++;
                }
            }
            return revArray;
        }
        public static double[] Reverse(double[] nums)
        {
            double[] revArray = new double[nums.Length];

            int array = nums.Length - 1;
            int rev = nums.Length - nums.Length;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                revArray[rev] = nums[array];
                if (array != 0)
                {
                    array--;
                    rev++;
                }
            }
            return revArray;
        }
        // makes a copy of the array
        public static int[] Copy(int[] nums)
        {
            int[] newArray = new int[nums.Length];
            newArray = nums;
            return newArray;
        }
        public static double[] Copy(double[] nums)
        {
            double[] newArray = new double[nums.Length];
            newArray = nums;
            return newArray;
        }
        // finds the index of the specified number
        public static int Find(int[] nums, int number)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (number == nums[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public static int Find(double[] nums, double number)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (number == nums[i])
                {
                    return i;
                }
            }
            return -1;
        }
        // gets the length of the array
        public static int GetLength(int[] nums)
        {
            int length = nums.Length;
            return length;
        }
        public static int GetLength(double[] nums)
        {
            int length = nums.Length;
            return length;
        }
    }
}


