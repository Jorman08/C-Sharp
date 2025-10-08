using POOWorkshop.Domain.Interfaces;

namespace POOWorkshop.Services.Payment;

public interface IPaymentCalculator
{
    decimal Calc(IPayable employee);
}
