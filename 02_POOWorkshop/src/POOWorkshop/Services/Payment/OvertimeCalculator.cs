using POOWorkshop.Domain.Interfaces;
using POOWorkshop.Domain.Payroll;

namespace POOWorkshop.Services.Payment;

public class OvertimeCalculator : IPaymentCalculator
{
    private readonly int _baseHours;
    private readonly decimal _overtimeFactor;

    public OvertimeCalculator(int baseHours = 160, decimal overtimeFactor = 1.25m)
    {
        _baseHours = baseHours;
        _overtimeFactor = overtimeFactor;
    }

    public decimal Calc(IPayable employee)
    {
        if (employee is Hourly h)
        {
            var baseHours = Math.Min(h.Hours, _baseHours);
            var extraHours = Math.Max(0, h.Hours - _baseHours);
            var basePay = h.Rate * baseHours;
            var overtimePay = h.Rate * _overtimeFactor * extraHours;
            return basePay + overtimePay;
        }
        return employee.CalculatePayment();
    }
}
