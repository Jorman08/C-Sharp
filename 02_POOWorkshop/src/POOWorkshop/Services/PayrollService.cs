using POOWorkshop.Domain.Interfaces;
using POOWorkshop.Services.Output;
using POOWorkshop.Services.Payment;

namespace POOWorkshop.Services;

public class PayrollService
{
    private readonly IPaymentCalculator _calc;
    private readonly IOutput _output;

    public PayrollService(IPaymentCalculator calculator, IOutput output)
    {
        _calc = calculator;
        _output = output;
    }

    public void Run(IEnumerable<IPayable> employees)
    {
        foreach (var e in employees)
        {
            var pay = _calc.Calc(e);
            _output.WriteLine($"{e.GetType().Name}: {pay:C0}");
        }
    }
}
