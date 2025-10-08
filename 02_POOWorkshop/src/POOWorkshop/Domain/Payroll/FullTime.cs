namespace POOWorkshop.Domain.Payroll;

public class FullTime : EmployeeBase
{
    public decimal Monthly { get; }

    public FullTime(string fullName, decimal monthly) : base(fullName)
    {
        if (monthly <= 0) throw new ArgumentOutOfRangeException(nameof(monthly));
        Monthly = monthly;
    }

    public override decimal CalculatePayment() => Monthly;

    public override string BuildReport() => $"FullTime -> {FullName}: {Monthly:C0}";
}
