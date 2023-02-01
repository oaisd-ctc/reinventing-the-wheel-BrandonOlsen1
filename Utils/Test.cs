using Xunit;
using MyUtilities;

public class Tests
{
    [Fact]
    //ArrayUtils
    public void ArrayReverseInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        ArrayUtils.Average(nums);
    }
    public void ArrayReverseDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        ArrayUtils.Average(nums);
    }
    public void ArrayMaxInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        ArrayUtils.Max(nums);
    }
    public void ArrayMaxDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        ArrayUtils.Max(nums);
    }
    public void ArrayMinInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        ArrayUtils.Min(nums);
    }
    public void ArrayMinDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        ArrayUtils.Min(nums);
    }
    public void ArraySortAccendingInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        ArrayUtils.SortAscending(nums);
    }
    public void ArraySortAccendingDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        ArrayUtils.SortAscending(nums);
    }
    public void ArraySortDeccendingInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        ArrayUtils.SortDecending(nums);
    }
    public void ArraySortDeccendingDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        ArrayUtils.SortDecending(nums);
    }
    public void ArraySumInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        ArrayUtils.Sum(nums);
    }
    public void ArraySumDouble()
    {
        int[] nums = { 1, 2, 3, 4 };
        ArrayUtils.Sum(nums);
    }
    // MathUtils 
    public void MathCeilingdouble()
    {
        double nums = 3.56;
        MathUtils.Ceiling(nums);
    }
    public void MathCeilingdecimal()
    {
        decimal nums = 3.67674m;
        MathUtils.Ceiling(nums);
    }
    public void MathFloorDouble()
    {
        double nums = 3.56;
        MathUtils.Floor(nums);
    }
    public void MathFloorDecimal()
    {
        decimal nums = 3.67674m;
        MathUtils.Floor(nums);
    }
    public void MathSignDouble()
    {
        double nums = 3.56;
        MathUtils.Sign(nums);
    }
    public void MathSignInt()
    {
        int nums = 3;
        MathUtils.Sign(nums);
    }
    public void MathExponentDouble()
    {
        double nums = 3.56;
        double power = 2;
        MathUtils.exponet(nums, power);
    }
    public void MathExponentInt()
    {
        int nums = 3;
        int power = 2;
        MathUtils.exponet(nums, power);
    }
    public void MathSquareDouble()
    {
        double nums = 3.56;
        MathUtils.Square(nums);
    }
    public void MathSquareInt()
    {
        int nums = 9;
        MathUtils.Square(nums);
    }
    public void MathAbsValueDouble()
    {
        double nums = -1;
        MathUtils.AbsoluteValue(nums);
    }
    public void MathAbsValueFloat()
    {
        float nums = -1;
        MathUtils.AbsoluteValue(nums);
    }
    public void MathAbsValueInt()
    {
        int nums = 9;
        MathUtils.AbsoluteValue(nums);
    }
    public void MathMaxInt()
    {
        int num1 = 4;
        int num2 = 5;
        MathUtils.Max(num1, num2);
    }
    public void MathMaxDouble()
    {
        double num1 = 4.45;
        double num2 = 4.46;
        MathUtils.Max(num1, num2);
    }
    public void MathMinInt()
    {
        int num1 = 4;
        int num2 = 5;
        MathUtils.Min(num1, num2);
    }
    public void MathMinDouble()
    {
        double num1 = 4;
        double num2 = 5;
        MathUtils.Min(num1, num2);
    }
    public void MathAddInt()
    {
        int num1 = 2;
        int num2 = 5;
        MathUtils.Add(num1, num2);
    }
    public void MathAddFloat()
    {
        float num1 = 2;
        float num2 = 5;
        MathUtils.Add(num1, num2);
    }
    public void MathAddDouble()
    {
        double num1 = 2;
        double num2 = 5;
        MathUtils.Add(num1, num2);
    }
    public void MathSubtractInt()
    {
        int num1 = 2;
        int num2 = 5;
        MathUtils.Subtract(num1, num2);
    }
    public void MathSubtractFloat()
    {
        float num1 = 2;
        float num2 = 5;
        MathUtils.Subtract(num1, num2);
    }
    public void MathSubtractDouble()
    {
        double num1 = 2.23;
        double num2 = 5.43;
        MathUtils.Subtract(num1, num2);
    }
    public void MathMultiplyInt()
    {
        int num1 = 3;
        int num2 = 3;
        MathUtils.Mulitply(num1, num2);
    }
    public void MathMultiplyFloat()
    {
        float num1 = 3;
        float num2 = 3;
        MathUtils.Mulitply(num1, num2);
    }
    public void MathMultiplyDouble()
    {
        double num1 = 3;
        double num2 = 3;
        MathUtils.Mulitply(num1, num2);
    }
    public void MathDivideInt()
    {
        int num1 = 50;
        int num2 = 10;
        MathUtils.Divide(num1, num2);
    }
    public void MathDivideDouble()
    {
        double num1 = 2.5;
        double num2 = 2;
        MathUtils.Divide(num1, num2);
    }
    public void MathDivideDecimal()
    {
        decimal num1 = 2.5m;
        decimal num2 = 2;
        MathUtils.Divide(num1, num2);
    }
    //StringUtils
}