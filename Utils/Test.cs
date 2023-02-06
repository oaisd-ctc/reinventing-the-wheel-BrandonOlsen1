using Xunit;
using MyUtilities;

public class Tests
{
    [Fact]
    //ArrayUtils
    public void ArrayAverageInt()
    {
        int[] nums = { 1, 2, 3, 4 };

        Assert.Equal(2, ArrayUtils.Average(nums));
    }
    [Fact]
    public void ArrayAverageDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        Assert.Equal(2.8125, ArrayUtils.Average(nums));
    }
    [Fact]
    public void ArrayMaxInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(4, ArrayUtils.Max(nums));
    }
    [Fact]
    public void ArrayMaxDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        Assert.Equal(4.1500000000000004, ArrayUtils.Max(nums));
    }
    [Fact]
    public void ArrayMinInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(0, ArrayUtils.Min(nums));
    }
    [Fact]
    public void ArrayMinDouble()
    {
        double[] nums = { 1.25, 2.33, 3.52, 4.15 };
        Assert.Equal(0, ArrayUtils.Min(nums));
    }
    [Fact]
    public void ArraySortAccendingInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.SortAscending(nums));
    }
    [Fact]
    public void ArraySortAccendingDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.SortAscending(nums));
    }
    [Fact]
    public void ArraySortDeccendingInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.SortDecending(nums));
    }
    [Fact]
    public void ArraySortDeccendingDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        double[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.SortDecending(nums));
    }
    [Fact]
    public void ArraySumInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(10, ArrayUtils.Sum(nums));
    }
    [Fact]
    public void ArraySumDouble()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(10, ArrayUtils.Sum(nums));
    }
    [Fact]
    public void ArrayProductInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(24, ArrayUtils.Product(nums));
    }
    [Fact]
    public void ArrayProductDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(24, ArrayUtils.Product(nums));
    }
    [Fact]
    public void ArrayReverseInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.Reverse(nums));
    }
    [Fact]
    public void ArrayReverseDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        double[] expected = { 4, 3, 2, 1 };
        Assert.Equal(expected, ArrayUtils.Reverse(nums));
    }
    [Fact]
    public void ArrayCopyInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.Copy(nums));
    }
    [Fact]
    public void ArrayCopyDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(nums, ArrayUtils.Copy(nums));
    }
    [Fact]
    public void ArrayFindInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        int num = 2;
        Assert.Equal(1, ArrayUtils.Find(nums, num));
    }
    [Fact]
    public void ArrayFindDouble()
    {
        double[] nums = { 1.5, 2.5, 3.5, 4.5 };
        double num = 3.5;
        Assert.Equal(2, ArrayUtils.Find(nums, num));
    }
    [Fact]
    public void ArrayGetLengthInt()
    {
        int[] nums = { 1, 2, 3, 4 };
        Assert.Equal(4, ArrayUtils.GetLength(nums));
    }
    [Fact]
    public void ArrayGetLengthDouble()
    {
        double[] nums = { 1, 2, 3, 4 };
        Assert.Equal(4, ArrayUtils.GetLength(nums));
    }

    // MathUtils 
    [Fact]
    public void MathCeilingdouble()
    {
        double nums = 3.56;
        Assert.Equal(4, MathUtils.Ceiling(nums));
    }
    [Fact]
    public void MathCeilingdecimal()
    {
        decimal nums = 3.67674m;
        Assert.Equal(4, MathUtils.Ceiling(nums));
    }
    [Fact]
    public void MathFloorDouble()
    {
        double nums = 3.56;
        Assert.Equal(3, MathUtils.Floor(nums));
    }
    [Fact]
    public void MathFloorDecimal()
    {
        decimal nums = 3.67674m;
        Assert.Equal(3, MathUtils.Floor(nums));
    }
    [Fact]
    public void MathSignDouble()
    {
        double nums = 3.56;
        Assert.Equal(1, MathUtils.Sign(nums));
    }
    [Fact]
    public void MathSignInt()
    {
        int nums = 3;
        Assert.Equal(1, MathUtils.Sign(nums));
    }
    [Fact]
    public void MathExponentDouble()
    {
        double nums = 3.56;
        double power = 2;
        Assert.Equal(12.6736, MathUtils.exponet(nums, power));
    }
    [Fact]
    public void MathExponentInt()
    {
        int nums = 3;
        int power = 2;
        Assert.Equal(9, MathUtils.exponet(nums, power));
    }
    [Fact]
    public void MathSquareDouble()
    {
        double nums = 3.56;
        Assert.Equal(1.8867963005177713, MathUtils.Square(nums));
    }
    [Fact]
    public void MathSquareInt()
    {
        int nums = 9;
        Assert.Equal(3.0000000078450579, MathUtils.Square(nums));
    }
    [Fact]
    public void MathAbsValueDouble()
    {
        double nums = -1;
        Assert.Equal(1, MathUtils.AbsoluteValue(nums));
    }
    [Fact]
    public void MathAbsValueFloat()
    {
        float nums = -1;
        Assert.Equal(1, MathUtils.AbsoluteValue(nums));
    }
    [Fact]
    public void MathAbsValueInt()
    {
        int nums = 9;
        Assert.Equal(9, MathUtils.AbsoluteValue(nums));
    }
    [Fact]
    public void MathMaxInt()
    {
        int num1 = 4;
        int num2 = 5;
        Assert.Equal(5, MathUtils.Max(num1, num2));
    }
    [Fact]
    public void MathMaxDouble()
    {
        double num1 = 4.45;
        double num2 = 4.46;
        Assert.Equal(4.46, MathUtils.Max(num1, num2));
    }
    [Fact]
    public void MathMinInt()
    {
        int num1 = 4;
        int num2 = 5;
        Assert.Equal(4, MathUtils.Min(num1, num2));
    }
    [Fact]
    public void MathMinDouble()
    {
        double num1 = 4;
        double num2 = 5;
        Assert.Equal(4, MathUtils.Min(num1, num2));
    }
    [Fact]
    public void MathAddInt()
    {
        int num1 = 2;
        int num2 = 5;
        Assert.Equal(7, MathUtils.Add(num1, num2));
    }
    [Fact]
    public void MathAddFloat()
    {
        float num1 = 2;
        float num2 = 5;
        Assert.Equal(7, MathUtils.Add(num1, num2));
    }
    [Fact]
    public void MathAddDouble()
    {
        double num1 = 2;
        double num2 = 5;
        Assert.Equal(7, MathUtils.Add(num1, num2));
    }
    [Fact]
    public void MathSubtractInt()
    {
        int num1 = 2;
        int num2 = 5;
        Assert.Equal(-3, MathUtils.Subtract(num1, num2));
    }
    [Fact]
    public void MathSubtractFloat()
    {
        float num1 = 2;
        float num2 = 5;
        Assert.Equal(-3, MathUtils.Subtract(num1, num2));
    }
    [Fact]
    public void MathSubtractDouble()
    {
        double num1 = 2.23;
        double num2 = 5.43;
        Assert.Equal(-3.1999999999999997, MathUtils.Subtract(num1, num2));
    }
    [Fact]
    public void MathMultiplyInt()
    {
        int num1 = 3;
        int num2 = 3;
        Assert.Equal(9, MathUtils.Mulitply(num1, num2));
    }
    [Fact]
    public void MathMultiplyFloat()
    {
        float num1 = 3;
        float num2 = 3;
        Assert.Equal(9, MathUtils.Mulitply(num1, num2));
    }
    [Fact]
    public void MathMultiplyDouble()
    {
        double num1 = 3;
        double num2 = 3;
        Assert.Equal(9, MathUtils.Mulitply(num1, num2));
    }
    [Fact]
    public void MathDivideInt()
    {
        int num1 = 50;
        int num2 = 10;
        Assert.Equal(5, MathUtils.Divide(num1, num2));
    }
    [Fact]
    public void MathDivideDouble()
    {
        double num1 = 2.5;
        double num2 = 2;
        Assert.Equal(1.25, MathUtils.Divide(num1, num2));
    }
    [Fact]
    public void MathDivideDecimal()
    {
        decimal num1 = 2.5m;
        decimal num2 = 2;
        Assert.Equal(1.25m, MathUtils.Divide(num1, num2));
    }

    //StringUtils
    [Fact]
    public void StringUpper()
    {
        string str = "Hi there";
        Assert.Equal("HI THERE", StringUtils.ToUpper(str));
    }
    [Fact]
    public void StringLower()
    {
        string str = "Hi there";
        Assert.Equal("Hi there", StringUtils.ToLower(str));
    }
    [Fact]
    public void StringReverse()
    {
        string str = "Hi there";
        Assert.Equal("ereht iH", StringUtils.Reverse(str));
    }
    [Fact]
    public void StringHasL()
    {
        string str = "Hi there";
        char letter = 'i';
        Assert.Equal(true, StringUtils.HasLetter(str, letter));
    }
    [Fact]
    public void StringVowels()
    {
        string str = "Hi there";
        Assert.Equal(3, StringUtils.CountVowels(str));
    }
    [Fact]
    public void StringConsonants()
    {
        string str = "Hi there";
        Assert.Equal(4, StringUtils.CountConsonants(str));
    }
    [Fact]
    public void StringRemove()
    {
        string str = "Hi there";
        char letter = 'i';
        Assert.Equal("H there", StringUtils.RemoveLetter(str, letter));
    }
    [Fact]
    public void StringHasW()
    {
        string str = "Hi there";
        Assert.Equal(false, StringUtils.ContainsNumber(str));
    }
    [Fact]
    public void StringReplace()
    {
        string str = "Hi there";
        char ltr = 'e';
        char rltr = 'L';
        Assert.Equal("Hi thLrL", StringUtils.ReplaceLetter(str, ltr, rltr));
    }
    [Fact]
    public void StringInsertW()
    {
        string str = "Hi there";
        string word = "you";
        int location = 2;
        Assert.Equal("Hiyouthere", StringUtils.InsertWord(str, word, location));
    }
}