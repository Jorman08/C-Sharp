namespace POOWorkshop.Domain.People;

// Sellada: no admite más herencia
// Justificación: ContractorPerson representa un tipo específico de trabajador independiente
// con características finales. Al ser sealed:
// 1. Se garantiza que la lógica de negocio no se modifique por herencia no controlada
// 2. Se mejora el rendimiento al evitar búsquedas de métodos virtuales
// 3. Se mantiene la integridad del diseño - un contractor es una entidad final en la jerarquía
public sealed class ContractorPerson : Person
{
    public decimal HourRate { get; }

    public ContractorPerson(string name, decimal hourRate)
        : base(name)
    {
        if (hourRate <= 0)
            throw new ArgumentOutOfRangeException(nameof(hourRate));
        HourRate = hourRate;
    }
}
