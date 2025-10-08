namespace POOWorkshop.Domain.People;

public class Person
{
    public string FullName { get; }

    public Person(string fullName)
    {
        FullName = string.IsNullOrWhiteSpace(fullName)
            ? throw new ArgumentException("FullName required", nameof(fullName))
            : fullName.Trim();
    }

    public virtual string Describe() => $"Persona: {FullName}";
}
