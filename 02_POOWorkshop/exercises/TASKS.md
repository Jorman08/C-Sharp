# Ejercicios guiados (FASE 2)

1) Product
   - Valida que `Name` tenga mínimo 3 caracteres.
   - Crea un constructor con `stock` por defecto (10).
   - Implementa `ApplyDiscount(decimal percent)` limitado 0–50%.

2) Herencia
   - Crea `Intern : EmployeeFullTimePerson` con `Months` y override de `Describe()`.
   - Justifica por qué `ContractorPerson` es `sealed` (comentarios).

3) Polimorfismo
   - En `Hourly`, agrega `SetBonus(decimal amount)` que afecte el cálculo.
   - Usa `List<IReportable>` para mostrar `BuildReport()`.

4) SOLID
   - Implementa `JsonOutput : IOutput` que escriba a `.json`.
   - Crea `WeekendOvertimeCalculator` (factor 1.5 si > 8 h/día). 
