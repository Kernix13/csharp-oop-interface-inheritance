# C# OOP Interface and Inheritance Project

This project is for learning advanced Object Oriented Programming concepts and syntax involving interfaces, inheritance, and polymorphism.

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

## Concepts and keywords to learn and add to this project

- Class inheritance: base class and derived class
  - Static constructors
  - the `override` keyword
- Interfaces
  - the `interface` keyword
  - interface implementation
- Polymorphism
  - Method overriding
  - `virtual` and `abstract` methods
  - Base class references (`.base`, `base()`)
  - Inheritance-based polymorphism
  - Interface-based polymorphism
  - Decouple
    - Tight coupling
    - Loose coupling
  - Class dependencies?
  - Dependency injection?
  - Design patterns?
- Public members
- Private members
- Protected members
- The `abstract` keyword
- The `virtual` keyword
- The `sealed` keyword
- The `new` keyword
- The `override` keyword
- The `base` keyword
- Instance property accessor?
- Method overloading
  - _Compile-time polymorphism_
- Method overriding
  - _Runtime polymorphism_
- Casting
  - The `is` and `as` keywords

<span aria-hidden="true"><br></span>

## In-depth Ccncepts and keywords definitions

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

- Static constructors:
- The `new` keyword in child class method signatures:
- The `abstract` keyword in parent classes:
- The `virtual` keyword in parent classes:
- The `override` keyword in child class method signatures:
  - `abstract` or `virtual` --> `override`
- Base/parent class: `abstract`, `virtual`, and `sealed`
  - The `sealed` keyword:
- `public`, `protected`, `internal`, and `private` keywords
- Method overriding (using `override`) and method hiding (using `new`)
- The `base` keyword
  - `base(arg1, arg2)`:
  - `base.MethodName()`:

<span aria-hidden="true"><br></span>

### Interface notes

- _Interface implementation_ allows a class to implement members defined in an interface
- A class can define its own behavior and implement the members defined in an interface.
- A class can inherit from multiple interfaces
- You should use interface implementation when a class can perform a specific set of actions?
- Create smaller, more specific interfaces rather than one large interface
- An interface doesn't hold any data itself
- Interfaces define methods but they don't provide the implementation for the methods
- An interface makes your related classes more consistent and easier to work with
- A method that takes an interface _parameter_ can interact with any object that implements the interface, irrespective of its specific class
- Interfaces help decouple class dependencies, making it easier to develop, test, and maintain the code
- the `interface` keyword

### Implement interface properties

- Start the process by designing an interface with properties.
  - Use the `interface` keyword to create an interface
- Then, you develop a class that implements these properties
- Define properties in the interface without a body
- When you implement these properties in a class, you'll write the actual code for getting (reading) and setting (writing) the values

<span aria-hidden="true"><br></span>

### Polymorphism: miscellaneous notes

<!-- - Polymorphism: a base class reference points to a derived class object? -->

- Polymorphism is based on Method overriding, `virtual` and `abstract` methods, base class references, and interface-based polymorphism
- Polymorphism decouples the code that uses objects from the code that defines the objects
- Polymorphism enables objects of different types to be treated as objects of a common base type, providing flexibility and reusability in code.
- _Polymorphism_: is primarily achieved through method overriding
- The classes and data that you're working with will determine whether inheritance-based or interface-based polymorphism is more appropriate

### Inheritance-based polymorphism

- Inheritance-based polymorphism is a common way to implement polymorphism in C#.
- Inheritance enables polymorphism, _which allows you to treat objects of a derived class as objects of their base class_. (?)
- When an app instantiates an object as a base class type and then assigns the object to a derived class instance, it's prepared to implement _polymorphism_.
- _Inheritance-based polymorphism_: Class inheritance in C# enables a derived class to inherit members from a base class. Members of the base class can be overridden in the derived class to provide specific implementations.
- **Inheritance-Based Polymorphism**: Using this approach can lead to _tight coupling_ because derived classes are directly dependent on the base class.
  - Changes in the base class can affect all derived classes.
- **Inheritance-based polymorphism** is appropriate in scenarios where you need to establish a clear hierarchical relationship between classes
- When you need to treat objects of different classes uniformly, inheritance-based polymorphism is ideal
- _When you create instances of the base class that reference the derived class types, you can access members of the derived class from the base class objects_.
- However, there are situations where inheritance-based polymorphism is the best approach, such as when you need to share common behavior across multiple classes.
- By using a base class reference, you can invoke overridden methods in derived classes, enabling polymorphic behavior

### Interface-based polymorphism

- Using interfaces for polymorphism generally promotes loose coupling
- _Interface-based polymorphism_: When a class implements an interface, the class receives a set of properties and methods that it's required to implement. This requirement allows for polymorphic behavior, where an interface reference can direct objects of different classes to implement the set of properties and methods.
- **Interface-Based Polymorphism**: This approach promotes _loose coupling_ by allowing classes to interact through interfaces rather than concrete implementations. This decouples the classes, making the system more flexible and easier to maintain.
- Interface-based polymorphism is useful in scenarios where you want to achieve loose coupling
- Interface-based polymorphism helps reduce dependencies between classes - allows you to change the implementation without affecting the rest of the system
- Interface-based polymorphism is appropriate when you need to reduce code dependencies, facilitate code standardization, enhance flexibility, decouple class dependencies, implement multiple inheritance, promote polymorphic behavior, support dependency injection, and implement design patterns
- Interface-based polymorphism is generally preferred over inheritance-based polymorphism because it promotes loose coupling
- Interfaces are key in facilitating polymorphic behavior in applications. They allow objects to be treated as instances of their interface types

### Polymorphism: additional terms:

- Method overriding:
- Virtual and abstract methods:
- Base class references:
- Decouple:
- Tight coupling:
- Loose coupling:
- Class dependencies:
- Dependency injection:
- Design patterns:

<span aria-hidden="true"><br></span>

## Other keywords + miscellaneous

- Public members:
- Protected members:
- Private members:
- The `abstract` keyword:
- The `virtual` keyword:
- The `sealed` keyword:
- The `new` keyword:
- The `override` keyword:
- The `base` keyword:
- Instance property accessor:
- Method overloading:
  - Compile-time polymorphism
- Method overriding:
  - Runtime polymorphism
- Casting
  - The `is` and `as` keywords
- Use File-Scoped Namespaces (`namespace Name;`)
- The Entry Point (`Program.cs`): Use Top-Level Statements (No namespace, no class, no Main) so `using NamespaceName`
- `IComparable`: Used for comparing objects.
- **`IEnumerable`**: Used for iterating over collections.
- `IDisposable`: Used for releasing unmanaged resources.
- `IEquatable`: Used for defining equality comparisons.

<span aria-hidden="true"><br></span>

## Code blocks

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
