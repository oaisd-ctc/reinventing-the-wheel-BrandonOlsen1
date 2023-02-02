using Xunit;
using MyUtilities;

public class Tests
{
    [Fact]
    //ArrayUtils
    public void ArrayAverageInt()
    {
        int[] nums = { 1, 2, 3, 4 };

        Assert.Equal(2.5, ArrayUtils.Average(nums));
    }
    public void ArrayAverageDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        Assert.Equal(2.81, ArrayUtils.Average(nums);
    }
    public void ArrayMaxInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(4, ArrayUtils.Max(nums));
    }
    public void ArrayMaxDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        Assert.Equal(4.15, ArrayUtils.Max(nums));
    }
    public void ArrayMinInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(1, ArrayUtils.Min(nums));
    }
    public void ArrayMinDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        Assert.Equal(1.25, ArrayUtils.Min(nums));
    }
    public void ArraySortAccendingInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.SortAscending(nums));
    }
    public void ArraySortAccendingDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.SortAscending(nums));
    }
    public void ArraySortDeccendingInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.SortDecending(nums));
    }
    public void ArraySortDeccendingDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        double[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.SortDecending(nums));
    }
    public void ArraySumInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(10, ArrayUtils.Sum(nums));
    }
    public void ArraySumDouble()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(10, ArrayUtils.Sum(nums));
    }
    public void ArrayProductInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(24, ArrayUtils.Product(nums));
    }
    public void ArrayProductDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(24, ArrayUtils.Product(nums));
    }
    public void ArrayReverseInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.Reverse(nums));
    }
    public void ArrayReverseDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        double[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.Reverse(nums));
    }
    public void ArrayCopyInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.Copy(nums));
    }
    public void ArrayCopyDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.Copy(nums));
    }
    public void ArrayFindInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        int num = 2;
        Assert.Equal(1, ArrayUtils.Find(nums, num));
    }
    public void ArrayFindDouble()
    {
        double[] nums = { 1.5, 2.5, 3.5, 4.5 };
        double num = 3.5;
        Assert.Equal(2, ArrayUtils.Find(nums, num));
    }
    public void ArrayGetLengthInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(4, ArrayUtils.GetLength(nums));
    }
    public void ArrayGetLengthDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(4, ArrayUtils.GetLength(nums));
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
    public void StringUpper()
    {
        string str = "Hi there";
        StringUtils.ToUpper(str);
    }
    public void StringLower()
    {
        string str = "Hi there";
        StringUtils.ToLower(str);
    }
    public void StringReverse()
    {
        string str = "Hi there";
        StringUtils.Reverse(str);
    }
    public void StringHasL()
    {
        string str = "Hi there";
        char letter = 'i';
        StringUtils.HasLetter(str, letter);
    }
    public void StringVowels()
    {
        string str = "Hi there";
        StringUtils.CountVowels(str);
    }
    public void StringConsonants()
    {
        string str = "Hi there";
        StringUtils.CountConsonants(str);
    }
    public void StringRemove()
    {
        string str = "Hi there";
        char letter = 'e';
        StringUtils.RemoveLetter(str, letter);
    }
    public void StringHasW()
    {
        string str = "Hi there";
        string word = "Hi";
        StringUtils.HasWord(str, word);
    }
    public void StringReplace()
    {
        // string 
    }
}