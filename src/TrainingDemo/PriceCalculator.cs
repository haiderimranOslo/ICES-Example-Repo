namespace TrainingDemo;

public static class PriceCalculator
{
    public static decimal ApplyDiscount(decimal price, decimal discountPercent)
    {
        if (price < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");
        }

        if (discountPercent is < 0 or > 100)
        {
            throw new ArgumentOutOfRangeException(
                nameof(discountPercent), "Discount must be between 0 and 100.");
        }

        return decimal.Round(price * (1 - discountPercent / 100m), 2);
    }
}
