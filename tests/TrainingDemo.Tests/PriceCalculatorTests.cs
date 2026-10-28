using TrainingDemo;
using Xunit;

namespace TrainingDemo.Tests;

public class PriceCalculatorTests
{
    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(50, 20, 40)]
    [InlineData(19.99, 0, 19.99)]
    [InlineData(80, 100, 0)]
    public void ApplyDiscount_ReturnsExpectedPrice(
        decimal price, decimal discountPercent, decimal expected)
    {
        var actual = PriceCalculator.ApplyDiscount(price, discountPercent);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-1, 10)]
    [InlineData(100, -1)]
    [InlineData(100, 101)]
    public void ApplyDiscount_RejectsInvalidInput(decimal price, decimal discountPercent)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => PriceCalculator.ApplyDiscount(price, discountPercent));
    }
}
