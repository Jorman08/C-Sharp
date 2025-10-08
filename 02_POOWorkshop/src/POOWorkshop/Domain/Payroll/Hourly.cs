namespace POOWorkshop.Domain.Payroll;

public class Hourly : EmployeeBase
{
    public decimal Rate { get; }
    public int Hours { get; }
    private decimal _bonus = 0m;

    public Hourly(string fullName, decimal rate, int hours)
        : base(fullName)
    {
        if (rate <= 0)
            throw new ArgumentOutOfRangeException(nameof(rate));
        if (hours < 0)
            throw new ArgumentOutOfRangeException(nameof(hours));
        Rate = rate;
        Hours = hours;
    }

    public void SetBonus(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Bonus cannot be negative");
        _bonus = amount;
    }

    public override decimal CalculatePayment() => (Rate * Hours) + _bonus;

    public override string BuildReport() =>
        $"Hourly -> {FullName}: {Rate:C0} x {Hours} + bonus {_bonus:C0} = {CalculatePayment():C0}";
}
