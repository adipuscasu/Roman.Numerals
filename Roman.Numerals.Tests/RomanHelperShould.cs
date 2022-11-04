using FluentAssertions;

namespace Roman.Numerals.Tests;

public class RomanHelperShould
{
    [Theory]
    [InlineData(0, "")]
    [InlineData(5, "V")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(9, "IX")]
    [InlineData(10, "X")]
    [InlineData(11, "XI")]
    [InlineData(50, "L")]
    [InlineData(40, "XL")]
    [InlineData(35, "XXXV")]
    [InlineData(90, "XC")]
    [InlineData(100, "C")]
    [InlineData(400, "CD")]
    [InlineData(500, "D")]
    [InlineData(800, "DCCC")]
    [InlineData(900, "CM")]
    [InlineData(1000, "M")]
    [InlineData(2000, "MM")]
    [InlineData(2432, "MMCDXXXII")]
    public void Convert(int value, string romanNumber)
    {
        // Act
        string result = RomanHelper.Convert(value);

        // Assert
        result.Should().Be(romanNumber);
    }
}