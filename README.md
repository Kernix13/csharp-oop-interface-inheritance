# C# OOP Interface and Inheritance Project

This project implements advanced Object Oriented Programming syntax involving interfaces, inheritance, and polymorphism.

> [!NOTE]
> Currently there is no code in this repo. I need to first organize all the concepts and syntax before I build a simple console application.

<span aria-hidden="true"><br></span>

## Installation & Usage

1. Clone this repository and switch into project folder

   ```sh
   git clone https://github.com/Kernix13/csharp-oop-interface-inheritance InventorySystem
   cd InventorySystem
   ```

2. Run the application

   ```bash
   dotnet run
   ```

3. Build the application

   ```bash
   dotnet build
   ```

### Quick Start

```sh
git clone https://github.com/Kernix13/csharp-oop-interface-inheritance.git InventorySystem
cd InventorySystem
dotnet run
```

<span aria-hidden="true"><br></span>

## Concepts and keywords and terminology to incorporate into this project

- Class inheritance: base class and derived class
  - Static and instance constructors
  - Properties and methods
  - the `new` keyword
  - the `override` keyword
- Interfaces
  - the `interface` keyword
  - interface implementation
  - Properties and methods
- Polymorphism
  - Method overriding
  - Virtual and abstract methods
  - Base class references
  - Interface-based polymorphism
  - Inheritance-based polymorphism
  - decouple
  - Tight coupling
  - Loose coupling
  - class dependencies
  - dependency injection
  - design patterns
- Public members
- Protected members
- Private members
- the `abstract` keyword
- the `virtual` keyword
- the `sealed` keyword
- the `new` keyword
- the `override` keyword
- the `base` keyword
- instance property accessor
- Method overloading
  - compile-time polymorphism
- Method overriding
  - runtime polymorphism
- Casting
  - the `is` and `as` keywords

<span aria-hidden="true"><br></span>

## Concepts and keywords and terminology definitions

### Inheritance: Base Class Notes

- _Class inheritance_ allows a class to inherit members from a base class
- A base class is used to define a common set of attributes and behaviors that other classes inherit
- A class can inherit from only one base class.

### Inheritance: Derived Class Notes

- A derived class can reuse, extend, and modify the behavior defined in the base class.
- A derived class is used to define a specialized set of attributes and behaviors
- You should use class inheritance when a derived class is a specialized version of a base class.
- Static and instance constructors aren't inherited.
- All other members of the base class are inherited
- You can define new properties and methods in the derived class that don't exist in the base class.
- You can define properties and methods in the derived class that override properties and methods in the base class. In such cases, you can use the `override` keyword to extend or modify the behavior of the base class members.

### Inheritance: miscellaneous notes

- Static and instance constructors
- Properties and methods
- the `new` keyword
- the `override` keyword
- `virtual`, `override`, and `abstract`
- base class: `abstract`, `virtual`, and `sealed`
- `abstract` or `virtual` --> `override`
- `public`, `protected`, `internal`, and `private`
- method overriding (using `override`) and method hiding (using `new`)
- The `base` keyword
- What is this syntax: `base(arg1, arg2)`

<span aria-hidden="true"><br></span>

### Interface:

- _Interface implementation_ allows a class to implement members defined in an interface
- A class can define its own behavior and implement the members defined in an interface.
- You should use interface implementation when a class can perform a specific set of actions.
- Create smaller, more specific interfaces rather than one large interface
- An interface doesn't hold any data itself
- Interfaces define methods but they don't provide the implementation for the methods
- An interface makes your related classes more consistent and easier to work with
- A method that takes an interface _parameter_ can interact with any object that implements the interface, irrespective of its specific class
- the `interface` keyword

### Implement interface properties

- Start the process by designing an interface with properties.
- Then, you develop a class that implements these properties
- Use the `interface` keyword to create an interface
- Define properties in the interface without a body
- When you implement these properties in a class, you'll write the actual code for getting (reading) and setting (writing) the values

<span aria-hidden="true"><br></span>

### Polymorphism

- Polymorphism
  - Method overriding
  - Virtual and abstract methods
  - Base class references
  - Interface-based polymorphism
  - Inheritance-based polymorphism
  - decouple
  - Tight coupling
  - Loose coupling
  - class dependencies
  - dependency injection
  - design patterns

<span aria-hidden="true"><br></span>

### All other keywords + miscellaneous

- Public members
- Protected members
- Private members
- the `abstract` keyword
- the `virtual` keyword
- the `sealed` keyword
- the `new` keyword
- the `override` keyword
- the `base` keyword
- instance property accessor
- Method overloading
  - compile-time polymorphism
- Method overriding
  - runtime polymorphism
- Casting
  - the `is` and `as` keywords
- Use File-Scoped Namespaces (`namespace Name;`)
- The Entry Point (`Program.cs`): Use Top-Level Statements (No namespace, no class, no Main) so `using NamespaceName`

```cs
class DerivedClass : BaseClass {}

public virtual string Method() {}
public override string Method() {}

// Note the type = BaseClass but instance of DerivedClass
// THIS IS polymorphism:
BaseClass someOtherClass = new DerivedClass();

// The MemberName can be a property, method, or field of the base class
base.MemberName

// Interface
public interface IName {}

// Implement an interface:
public class ClassName : IName {}


// inheritance - BASE
public class HousePet {
    public virtual string Speak() {
        return "Hello";
    }
}
// inheritance - DERIVED
public class Dog : HousePet {
    public override string Speak() {
        return "Woof";
    }
}

// inheritance - BASE
public class BaseClass
{
    internal int internalField;
    internal void InternalMethod() { }
}
// inheritance - DERIVED
public class DerivedClass : BaseClass
{
    public void AccessInternalMember()
    {
        internalField = 10;
        InternalMethod();
    }
}
```

```sh
# This is a quick way to create files
echo "namespace NamespaceName;" > FileName1.cs
```

<!-- The local repo folder name is: InventorySystem -->
