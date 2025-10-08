using POOWorkshop.Domain.Interfaces;

namespace POOWorkshop.Services.Payment;

public class DefaultPaymentCalculator : IPaymentCalculator
{
    public decimal Calc(IPayable employee) => employee.CalculatePayment();
}
