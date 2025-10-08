using POOWorkshop.Domain.Interfaces;

namespace POOWorkshop.Domain.Payroll;

public abstract class EmployeeBase : IPayable, IReportable
{
    public string FullName { get; }

    protected EmployeeBase(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("FullName required", nameof(fullName));
        FullName = fullName.Trim();
    }

    public virtual string Describe() => $"Empleado: {FullName}";

    public abstract decimal CalculatePayment();
    public abstract string BuildReport();
}
