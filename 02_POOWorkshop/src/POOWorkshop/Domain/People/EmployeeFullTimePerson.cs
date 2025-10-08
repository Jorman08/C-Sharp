namespace POOWorkshop.Domain.People;

public class EmployeeFullTimePerson : Person
{
    public decimal Salary { get; }

    public EmployeeFullTimePerson(string name, decimal salary) : base(name)
    {
        if (salary <= 0) throw new ArgumentOutOfRangeException(nameof(salary));
        Salary = salary;
    }

    public override string Describe() => $"Empleado FT: {FullName}, salario: {Salary:C0}";
}
