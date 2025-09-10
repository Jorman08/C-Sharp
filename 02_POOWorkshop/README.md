# POOWorkshop (C# / .NET 8)

Taller práctico de Programación Orientada a Objetos (FASE 2).

## Requisitos
- .NET 8 SDK
- VS Code o Visual Studio

## Ejecutar
```
cd src/POOWorkshop
dotnet restore
dotnet run
```
# POOWorkshop (C# / .NET 8)

Sistema de demostracion de conceptos de Programacion Orientada a Objetos aplicados a un sistema de gestion de empleados y productos.

## Descripcion del Proyecto

Este proyecto implementa un sistema completo que demuestra los pilares fundamentales de POO a traves de un dominio de negocio realista que incluye gestion de productos, empleados y calculo de nominas.

## Arquitectura del Sistema

### Estructura de Directorios


src/POOWorkshop/
├── Domain/                 # Entidades del dominio
│   ├── Product.cs         # Clase producto con encapsulamiento
│   ├── Interfaces/        # Contratos del sistema
│   │   ├── IPayable.cs   # Interface para calculo de pagos
│   │   └── IReportable.cs # Interface para generacion de reportes
│   ├── Payroll/          # Jerarquia de empleados
│   │   ├── EmployeeBase.cs    # Clase base abstracta
│   │   ├── FullTime.cs        # Empleado tiempo completo
│   │   └── Hourly.cs          # Empleado por horas
│   └── People/           # Jerarquia de personas
│       ├── Person.cs              # Clase base
│       ├── EmployeeFullTimePerson.cs
│       ├── Manager.cs
│       ├── ContractorPerson.cs
│       └── Intern.cs
├── Services/             # Servicios de aplicacion
│   ├── PayrollService.cs # Servicio principal de nomina
│   ├── Output/          # Estrategias de salida
│   │   ├── IOutput.cs
│   │   ├── ConsoleOutput.cs
│   │   ├── FileOutput.cs
│   │   └── JsonOutput.cs
│   └── Payment/         # Calculadoras de pago
│       ├── IPaymentCalculator.cs
│       ├── DefaultPaymentCalculator.cs
│       ├── OvertimeCalculator.cs
│       └── WeekendOvertimeCalculator.cs
└── Program.cs           # Menu interactivo de demos


## Conceptos POO Implementados

### 1. Encapsulamiento

- *Product*: Validacion de propiedades con setters privados
- *EmployeeBase*: Proteccion de datos con modificadores de acceso
- Validaciones de negocio en constructores y metodos

### 2. Herencia

- *Person* como clase base para toda la jerarquia de personas
- *EmployeeBase* como clase abstracta para empleados
- Especializaciones: Manager, Intern, ContractorPerson
- Uso de sealed en ContractorPerson para prevenir herencia adicional

### 3. Polimorfismo

- *IPayable*: Diferentes implementaciones de calculo de pago
- *IReportable*: Multiples formatos de reporte
- *IOutput*: Diferentes destinos de salida (consola, archivo, JSON)
- *IPaymentCalculator*: Algoritmos de calculo intercambiables

### 4. Abstraccion

- Interfaces que definen contratos claros
- Clase abstracta EmployeeBase con metodos abstractos
- Separacion de responsabilidades por capas

## Principios SOLID Aplicados

### Single Responsibility Principle (SRP)

- Cada clase tiene una responsabilidad unica y bien definida
- Separacion entre dominio, servicios y salida

### Open/Closed Principle (OCP)

- Sistema abierto para extension via interfaces
- Nuevos calculadores y outputs sin modificar codigo existente

### Liskov Substitution Principle (LSP)

- Cualquier implementacion de IPayable puede usarse indistintamente
- Jerarquia de herencia respeta contratos base

### Interface Segregation Principle (ISP)

- Interfaces pequeñas y especificas (IPayable, IReportable, IOutput)
- Clientes no dependen de metodos que no usan

### Dependency Inversion Principle (DIP)

- PayrollService depende de abstracciones (interfaces)
- Inversion de control via constructor injection
- Bajo acoplamiento entre componentes

## Funcionalidades Principales

### 1. Gestion de Productos

- Creacion con validaciones de negocio
- Aplicacion de descuentos con limites
- Control de stock y precios

### 2. Sistema de Empleados

- Jerarquia completa de tipos de empleado
- Calculo de salarios diferenciado por tipo
- Sistema de bonos para empleados por horas

### 3. Motor de Nomina

- Calculo automatizado de pagos
- Multiples estrategias de calculo (normal, overtime, weekend)
- Salida configurable (consola, archivo, JSON)

### 4. Sistema de Reportes

- Generacion de reportes por empleado
- Formato estructurado de informacion
- Extensible para nuevos tipos de reporte

## Patrones de Diseño Utilizados

- *Strategy Pattern*: IPaymentCalculator, IOutput
- *Template Method*: EmployeeBase con metodos abstractos
- *Factory Method*: Constructores especializados en Product
- *Dependency Injection*: PayrollService recibe dependencias

## Requisitos del Sistema

- .NET 8 SDK
- VS Code o Visual Studio

## Instrucciones de Ejecucion

bash
cd src/POOWorkshop
dotnet restore
dotnet build
dotnet run


## Demos Disponibles

1. *Clases y Objetos*: Demostracion de encapsulamiento con Product
2. *Herencia*: Jerarquia de Person y especializaciones
3. *Polimorfismo*: Uso de interfaces IPayable con diferentes empleados
4. *Abstraccion + SOLID*: PayrollService con inversion de dependencias
5. *Nuevas Funcionalidades*: Features extendidas del sistema

## Casos de Uso Cubiertos

- Calculo de nomina para diferentes tipos de empleado
- Aplicacion de descuentos a productos con validaciones
- Generacion de reportes en multiples formatos
- Gestion de horas extra y bonificaciones
- Salida de datos a diferentes destinos

## Validaciones Implementadas

- Nombres de producto minimo 3 caracteres
- Precios y stock no negativos
- Descuentos limitados a 50% maximo
- Nombres de empleados requeridos
- Horas trabajadas dentro de rangos validos