namespace POOWorkshop.Domain.People;

public class Intern : EmployeeFullTimePerson
{
    public int Months { get; }

    public Intern(string name, decimal salary, int months)
        : base(name, salary)
    {
        if (months <= 0)
            throw new ArgumentOutOfRangeException(nameof(months), "Months must be greater than 0");
        Months = months;
    }

    public override string Describe() =>
        $"Interno: {FullName}, salario: {Salary:C0}, duración: {Months} meses";
}
