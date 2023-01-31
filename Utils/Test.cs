using Xunit;

public class Tests
{
    [Fact]
    public void ArrayReverseInt()
    {
        int[] nums = {1, 2, 3, 4};
        ArrayUtils.Average(nums);
    }
    public void ArrayReverseDouble()
    {
        double[] nums = {1.25, 2.33, 3.52, 4.15};
        ArrayUtils.Average(nums);
    }
    public void ArrayMaxInt()
    {
        int[] nums = {1, 2, 3, 4};
        ArrayUtils.Max(nums);
    }
    public void ArrayMaxDouble()
    {
        double[] nums = {1.25, 2.33, 3.52, 4.15};
        ArrayUtils.Max(nums);
    }
    public void ArrayMinInt()
    {
        int[] nums = {1, 2, 3, 4};
        ArrayUtils.Min(nums);
    }
    public void ArrayMinDouble()
    {
        double[] nums = {1.25, 2.33, 3.52, 4.15};
        ArrayUtils.Min(nums);
    }
    public void ArraySortAccendingInt()
    {
        int[] nums = {1, 2, 3, 4};
        ArrayUtils.SortAscending(nums);
    }
    public void ArraySortAccendingDouble()
    {
        double[] nums = {1, 2, 3, 4};
        ArrayUtils.SortAscending(nums);
    }
    public void ArraySortDeccendingInt()
    {
        int[] nums = {1, 2, 3, 4};
        ArrayUtils.SortDecending(nums);
    }
    public void ArraySortDeccendingDouble()
    {
        double[] nums = {1, 2, 3, 4};
        ArrayUtils.SortDecending(nums);
    }
    public void ArraySumInt()
    {
        int[] nums = {1, 2, 3, 4};
        ArrayUtils.Sum(nums);
    }
    public void ArraySumDouble()
    {
        int[] nums = {1, 2, 3, 4};
        ArrayUtils.Sum(nums);
    }
}