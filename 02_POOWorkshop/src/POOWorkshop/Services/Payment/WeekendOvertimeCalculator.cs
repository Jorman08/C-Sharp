using POOWorkshop.Domain.Interfaces;
using POOWorkshop.Domain.Payroll;

namespace POOWorkshop.Services.Payment;

public class WeekendOvertimeCalculator : IPaymentCalculator
{
    private readonly decimal _overtimeFactor;
    private readonly int _maxHoursPerDay;

    public WeekendOvertimeCalculator(decimal overtimeFactor = 1.5m, int maxHoursPerDay = 8)
    {
        _overtimeFactor = overtimeFactor;
        _maxHoursPerDay = maxHoursPerDay;
    }

    public decimal Calc(IPayable employee)
    {
        if (employee is Hourly h)
        {
            // Asumimos que las horas están distribuidas en días laborales (lunes-viernes)
            // Si hay más de 8 horas por día, aplicamos factor de 1.5
            var workDays = 5; // lunes a viernes
            var regularHoursPerDay = Math.Min(h.Hours / workDays, _maxHoursPerDay);
            var overtimeHoursPerDay = Math.Max(0, (h.Hours / workDays) - _maxHoursPerDay);

            var totalRegularHours = regularHoursPerDay * workDays;
            var totalOvertimeHours = overtimeHoursPerDay * workDays;

            var regularPay = h.Rate * totalRegularHours;
            var overtimePay = h.Rate * _overtimeFactor * totalOvertimeHours;

            return regularPay + overtimePay;
        }
        return employee.CalculatePayment();
    }
}
