namespace POOWorkshop.Domain.People;

public class Manager : EmployeeFullTimePerson
{
    public int TeamSize { get; }

    public Manager(string name, decimal salary, int teamSize) : base(name, salary)
    {
        if (teamSize < 0) throw new ArgumentOutOfRangeException(nameof(teamSize));
        TeamSize = teamSize;
    }

    public override string Describe() => $"Manager: {FullName}, salario: {Salary:C0}, equipo: {TeamSize}";
}
