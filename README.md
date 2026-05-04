# C# OOP Interface and Inheritance Project

This project is for learning advanced Object Oriented Programming concepts and syntax involving interfaces, inheritance, and polymorphism. The project name is `InventorySystem`. I have inventory management experience so this works with classes and interfaces.

This README has notes on the concepts and keywords used is the `.cs` files.

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
- Interfaces
  - the `interface` keyword
  - interface implementation
- Polymorphism
  - Method overriding
  - `virtual` and `abstract` methods + the `override` keyword
  - Base class references (`base.MemberName`, `base()`)
  - Inheritance-based polymorphism
  - Interface-based polymorphism
  - Tight coupling & Loose coupling
  - Class dependencies?
  - Dependency injection?
  - Design patterns?
- Public, private, internal, and protected members
- The `abstract`, `virtual`, `sealed`, `override`, and `base` keywords
- Method overloading (_Compile-time polymorphism_)
- Method overriding (_Runtime polymorphism_)
- Casting: The `is` and `as` keywords

<span aria-hidden="true"><br></span>

## In-depth Ccncepts and keywords definitions

### Interface notes

> Interfaces cannot contain fields; they can only contain properties & methods!

- _Interface implementation_ allows a class to implement members defined in an interface
- A class can define its own behavior and implement the members defined in an interface.
- A class can inherit from multiple interfaces
- You should use interface implementation when a class can perform a specific set of actions (?)
- Create smaller, more specific interfaces rather than one large interface
- An interface doesn't hold any data itself
- Interfaces define methods but they don't provide the implementation for the methods
- An interface makes your related classes more consistent and easier to work with
- A method that takes an interface _parameter_ can interact with any object that implements the interface, irrespective of its specific class (Advanced)
- Interfaces help decouple class dependencies, making it easier to develop, test, and maintain the code
- You create an interface using the `interface` keyword

#### Implement interface properties

- Start the process by designing an interface with properties.
  - Use the `interface` keyword to create an interface
- Then, you develop a class that implements these properties
- Define properties in the interface without a body
- When you implement these properties in a class, you'll write the actual code for getting (reading) and setting (writing) the values

> The specific pattern: **Interface → Base Class → Derived Class** - that is a professional "Gold Standard" in C# development.

1. Interface -> The Contract. Defines what must be done.
2. Base Class -> The Blueprint. Defines how things are done by default (shared code).
3. Derived Class -> Specifics. Handles the unique details.

Example interface from this project:

```cs
namespace InventorySystem;
// Used in Product.cs
public interface IInventoryItem
{
    // These are just my starter properties for now
    public string ItemNumber { get; set; }
    public int QuantityOnHand { get; set; }
    public int QuantityOnOrder { get; }
    public int QuantityOnBackOrder { get; set; }

    string DisplayItemInfo();
}
```

I have preliminary code blocks at the end of the file for my interfaces `IPurchaseOrder` and `ISupplyVendor` (bad name).

<span aria-hidden="true"><br></span>

### Inheritance: Base Class Notes

- _Class inheritance_ allows a class to inherit members from a base class
- A base class is used to define a common set of attributes and behaviors that other classes inherit
- **A class can inherit from only one base class**.

Example base class from this project:

```cs
namespace InventorySystem;
// I don't know if I should use the 'abstract' keyword or not
// see IInventoryItem above
public class Product : IInventoryItem
{
    // You must implement everything the interface asked for
    public string ItemNumber { get; set; }
    public int QuantityOnHand { get; set; }
    public int QuantityOnOrder { get; set; }
    public int QuantityOnBackOrder { get; set; }

    // Base Constructor
    public Product(string itemNumber, int onHand, int onOrder, int onBackOrder)
    {
        ItemNumber = itemNumber;
        QuantityOnHand = onHand;
        QuantityOnOrder = onOrder;
        QuantityOnBackOrder = onBackOrder;
    }

    // 'virtual' keyword - How often is 'abstract' used?
    public virtual string DisplayItemInfo()
    {
        return $"Item Number: {ItemNumber}, Quantity On Hand: {QuantityOnHand}, Quantity On Order: {QuantityOnOrder}, Quantity On Back Order: {QuantityOnBackOrder}";
    }
}
```

Product has:

- a `public` class
- a `public` constructor
- a `public virtual` method

### Inheritance: Derived Class Notes

- A derived class can reuse, extend, and modify the behavior defined in the base class.
- A derived class is used to define a specialized set of attributes and behaviors
- Use class inheritance when a derived class is a specialized version of a base class (?)
- Static and instance constructors aren't inherited.
- All other members of the base class are inherited
- You can define new properties and methods in the derived class that don't exist in the base class.
- Override the members of a base class by using the `virtual` or `abstract` keywords in the base class, and `override` in the derived/child class.
- Base and derived classes use the `abstract`, `virtual`, and `sealed` keywords to control the behavior of members that are inherited (?)
- You can define properties and methods in the derived class that override properties and methods in the base class. In such cases, you can use the `override` keyword to extend or modify the behavior of the base class members.

**NOTE**: If you want to pass the values in when you create the instance, you should put the main constructor in the Base Class to handle the shared fields

Example derived class from this project:

```cs
namespace InventorySystem;

public class DatedProduct : Product
{
    // Constructor using base()
    public DatedProduct(string itemNumber, int onHand, int onOrder, int onBackOrder)
        : base(itemNumber, onHand, onOrder, onBackOrder) { }

    // 'override' for 'virtual' method in Product.cs
    public override string DisplayItemInfo()
    {
        return $"Item Number: {ItemNumber}, Quantity On Hand: {QuantityOnHand}";
    }
}
```

### Inheritance: miscellaneous notes

> _THIS SECTION IS WAY TOO LONG, MOSTLY FROM BASE & CASTING_

Before you can override the members in a derived class, you must declare the members in the base class as either `abstract` or `virtual`.

#### `virtual` and `abstract` keywords:

- The `virtual` keyword is used to declare methods in the base class that can be overridden in the derived classes - the member has an implementation but **can be** overridden or extended in a derived class.
- The `abstract` keyword is used for declaring methods that must be overridden in derived classes - the member has no implementation and **must be** overridden in a derived class.

#### `abstract` keyword:

- **An `abstract` <ins>class</ins> can't be instantiated directly and is intended to be a base class for other classes**
- The `abstract` keyword in parent classes: is used to define classes and class members _that are incomplete and must be implemented in derived classes_
- Abstract methods and properties are declared without any implementation and **_MUST BE overridden_** in ~~nonabstract~~ derived classes.
- Derived classes **_MUST_** provide implementations for **_ALL_** abstract members of the abstract class.
- Derived classes **_MUST_** override these methods and provide the implementation.
- Abstract properties: Similar to abstract methods, abstract properties are declared without implementation and **_MUST BE overridden_** in derived classes.

Defining an `abstract` base class:

- When you define a base class as abstract, you indicate that the class is incomplete and must be implemented by derived classes
- Abstract classes can contain abstract properties and/or methods that must be implemented by derived classes
- Abstract base classes can't be instantiated directly, so they're used as a template for derived classes to implement the abstract members
  - You must create instances of the derived classes that implement the abstract members
  - The derived class must provide implementations for the abstract members defined in the base class
  - Members that **_aren't `abstract`_** can be overridden (`override`) or hidden (`new`) in the derived class

#### `virtual` keyword:

- The `virtual` keyword in parent classes: allows you to override the parent in the child class
- The `virtual` keyword in C# is used to define methods and properties that can be overridden in derived classes.
- A virtual method or property has an implementation in the base class, but it can be extended or modified in derived classes.
- You do not need to add/implement a method in your child class for a parent method that is virtual

The following rules describe how the `virtual` keyword affects inheritance:

- Virtual methods: A virtual method has an implementation in the base class, but it can be overridden in derived classes.
- Virtual properties: Similar to virtual methods, virtual properties have an implementation in the base class and can be overridden in derived classes.

#### `override` keyword:

In C#, you can use the `override` keyword to extend or modify the behavior of the base class in the derived class. The `override` keyword enables you to override properties and methods that are inherited from the base class, and provide custom implementations in the derived class.

- The `override` keyword in child class method signatures:
  - `abstract` or `virtual` in base --> `override` in child
  - After you declare the members in the base class as either `abstract` or `virtual`, you can override the members in the derived class using the `override` keyword
  - The `override` keyword indicates that the member in the derived class overrides the member in the base class.
- Use the `override` keyword to extend or modify the behavior of the base class members
- Method overriding (using `override`) and method hiding (using `new`)
- The `base` keyword
  - `base(arg1, arg2)`
  - `base.MethodName()`
  - `base.MemberName`

To override a property or method in a derived class, you must follow these steps:

- Declare the members in the base class as either `abstract` or `virtual`.
- Override the members in the derived class using the `override` keyword.
- Optionally, use the `base` keyword to access the base class implementation from the overridden member in the derived class.

#### `base` keyword:

A derived class that replaces or overrides a base class method or property can still access the method or property on the base class by using the `base` keyword. This enables you to call base class constructors, methods, and properties from overridden members of a derived class.

- Use the `base` keyword to access base class members from a derived class.
- Use the `base` keyword _to call_ base class constructors from derived class constructors (?)
- Use the `base` keyword to access base class fields, properties, and methods from overridden methods in a derived class.

By using the `base` keyword, you can ensure that the derived class properly reuses and extends the functionality provided by the base class.

The `base` keyword is used to accomplish the following tasks:

- To call a base class method from an overridden method of the derived class.
- To implement a base-class constructor from within the constructor of the derived class.

The base keyword has the following restrictions:

- The `base` keyword can only be used in a constructor, an instance method, or an instance property accessor.
- The `base` keyword can't be used in a static method. Attempting to use the `base` keyword in a static method will generate an error.

When you implement the `base` keyword in a derived class, your code uses the base class specified in the class declaration (???)

Accessing the properties and methods of a base class from a derived class is a common requirement when implementing inheritance. The following code demonstrates the syntax for implementing the `base` keyword:

```cs
// The MemberName can be a property or field of the base class
base.MemberName
base.MethodName()
```

Class constructors in the base class can be accessed from constructors of the derived class by using the `base` keyword.

Calling the base class constructor from the derived class constructor is important. For example, when the base class constructor initializes common properties that are used by the derived class. By calling the base class constructor from the derived class constructor, you ensure that the common properties are initialized before the derived class constructor executes.

> **NOTE**: It's best practice for virtual members to use `base` to call the base class implementation of that member in their own implementation. Letting the base class behavior occur enables the derived class to concentrate on implementing behavior specific to the derived class. If the base class implementation isn't called, it's up to the derived class to make their behavior compatible with the behavior of the base class. (?)

#### `public`, `protected`, `internal`, and `private` keywords:

- _Public members_ are accessible from any code that has access to the class.
  - Derived classes inherit public members and they're accessible from outside the class hierarchy
- _Protected members_ are accessible within the class in which they're declared and within derived classes. They aren't accessible from outside the class hierarchy
  - If you try to access protected members from outside the class hierarchy, a compile-time error is generated
- _Internal members_ are accessible within the same assembly. They aren't accessible from outside the assembly, even if the class is inherited. (?)
  - If you try to access internal members from outside the assembly, a compile-time error is generated
- _Private members_ are accessible only within the class in which they're declared. Derived classes don't inherit private members, so they're not directly accessible in the derived class

#### Casting

Cast an object of a base class to a derived class

Casting in C# is the process of converting an object of one type to another type. Casting is often used when implementing polymorphism using inheritance hierarchies, where you have a base class and one or more derived classes.

There are two main types of casting:

- Implicit Casting: This occurs automatically when converting a derived class to a base class. It is safe because every instance of a derived class is also an instance of the base class: `BankAccount account = new CheckingAccount();`
- Explicit Casting: This requires a cast operator and is used when converting a base class to a derived class. It's not always safe because not every instance of a base class is an instance of the derived class:
  - `CheckingAccount checkingAccount = (CheckingAccount)account;`

Cast objects by using the `is` and `as` keywords

In C#, you can cast objects using the `is` and `as` keywords. These keywords provide a safe way to check the type of an object before casting it to another type. Here are some common ways to cast objects in C#:

- Using the `is` keyword with pattern matching:
  - This syntax checks if `account` is of type `CheckingAccount`.
  - If the check is successful, it casts `account` to `CheckingAccount` and assigns it to the variable `checkingAccount`.
  - This approach is concise and safe, as it combines the type check and cast in one step.

```cs
if (account is CheckingAccount) {
    CheckingAccount checkingAccount = (CheckingAccount)account;
    // Use checkingAccount as a CheckingAccount
}
```

- Using the `as` keyword:
  - This syntax attempts to cast `account` to `CheckingAccount` and assigns the result to `checkingAccount`.
  - If the cast is successful, `checkingAccount` contains the cast object; otherwise, it is `null`.
  - This approach is useful when you want to check the cast result before using the cast object. For example, when you want to avoid exceptions and handle the failure case gracefully.

```cs
CheckingAccount checkingAccount = account as CheckingAccount;

if (checkingAccount != null) {
    // Use checkingAccount as a CheckingAccount
}
```

When implementing casting, consider the following guidelines:

- Using pattern matching with `is`: Combines type check and cast in one step.
- Using the `is` keyword with explicit cast: Separates type check and cast into two steps, providing more control over the casting process.
- Using the `as` keyword: Attempts cast and handles failure gracefully by returning null.
- do upcasting not down casting?!?

> Understanding these casting techniques is essential for working with polymorphism and inheritance in C#.

<span aria-hidden="true"><br></span>

### Polymorphism: miscellaneous notes

<!-- - Polymorphism: a base class reference points to a derived class object? -->

- Polymorphism is based on Method overriding, `virtual` and `abstract` methods, base class references, and interface-based polymorphism
- Polymorphism decouples the code that uses objects from the code that defines the objects
- Polymorphism enables objects of different types to be treated as objects of a common base type, providing flexibility and reusability in code.
- **_Polymorphism_: is primarily achieved through method overriding**
- The classes and data that you're working with will determine whether inheritance-based or interface-based polymorphism is more appropriate

> While polymorphism can be implemented in both tightly and loosely coupled systems, using interfaces for polymorphism generally promotes loose coupling

### Inheritance-based polymorphism

- Inheritance-based polymorphism is a common way to implement polymorphism in C#.
- Inheritance enables polymorphism, _which allows you to treat objects of a derived class as objects of their base class_.
- When an app instantiates an object as a base class type and then assigns the object to a derived class instance, it's prepared to implement _polymorphism_.
- _Inheritance-based polymorphism_: Class inheritance in C# enables a derived class to inherit members from a base class. Members of the base class can be overridden in the derived class to provide specific implementations.
- **Inheritance-Based Polymorphism**: Using this approach can lead to _tight coupling_ because derived classes are directly dependent on the base class.
  - Changes in the base class can affect all derived classes.
- **Inheritance-based polymorphism** is appropriate in scenarios where you need to establish a clear hierarchical relationship between classes
- When you need to treat objects of different classes uniformly, inheritance-based polymorphism is ideal
- _When you create instances of the base class that reference the derived class types, you can access members of the derived class from the base class objects_ (?)
- There are situations where inheritance-based polymorphism is the best approach, such as when you need to share common behavior across multiple classes.
- By using a base class reference, you can invoke overridden methods in derived classes, enabling polymorphic behavior

Example from Program.cs

```cs
/*  Is this:
    Inheritance-based polymorphism - or
    Interfaced-based polymorphism */

// IInventoryItem (interface) > Product (base) > DatedProduct (derived)
IInventoryItem product1 = new DatedProduct("mnop", 150, 0, 0);
Console.WriteLine(product1.DisplayItemInfo());

// IInventoryItem (interface) > Product (base) > StandardProduct (derived)
IInventoryItem product2 = new StandardProduct("xyz123", 10, 50, 17);
Console.WriteLine(product2.DisplayItemInfo());
```

### Interface-based polymorphism

- Using interfaces for polymorphism generally promotes loose coupling
- _Interface-based polymorphism_: When a class implements an interface, the class receives a set of properties and methods that it's required to implement. This requirement allows for polymorphic behavior, where an interface reference can direct objects of different classes to implement the set of properties and methods.
- **Interface-Based Polymorphism**: This approach promotes _loose coupling_ by allowing classes to interact through interfaces rather than concrete implementations. This decouples the classes, making the system more flexible and easier to maintain.
- Interface-based polymorphism is useful in scenarios where you want to achieve loose coupling
- Interface-based polymorphism helps reduce dependencies between classes - allows you to change the implementation without affecting the rest of the system
- Interface-based polymorphism is appropriate when you need to reduce code dependencies, facilitate code standardization, enhance flexibility, decouple class dependencies, implement multiple inheritance, promote polymorphic behavior, support dependency injection, and implement design patterns
- Interface-based polymorphism is generally preferred over inheritance-based polymorphism because it promotes loose coupling
- Interfaces are key in facilitating polymorphic behavior in applications. They allow objects to be treated as instances of their interface types

### Additional Polymorphism terms:

- Virtual and abstract methods: SEE ABOVE
- Base class references: Polymorphism allows a base class reference to point to objects of derived classes. This inheritance mechanism enables the invocation of overridden methods in derived classes through the base class reference.
- Decoupling & class dependencies: Interfaces help decouple class dependencies, making it easier to develop, test, and maintain the code. Decoupling is especially important in large systems where changes in one part of the code should not affect other parts
  - Tight coupling (Inheritance-Based Polymorphism): Tight coupling occurs when classes or components in a system are highly dependent on each other. This means that changes in one class can directly affect other classes, making the system less flexible and harder to maintain. Tight coupling can lead to difficulties in testing, extending, and modifying the code.
  - Loose coupling (Interface-Based Polymorphism): refers to a design where classes or components have minimal dependencies on each other. This design principle enhances flexibility, maintainability, and testability by reducing the interdependencies between components.
- Design patterns?

#### Method overloading versus method overriding:

Method overloading and method overriding are two common techniques for implementing method calls that produce different behaviors. Here's a comparison of the two techniques:

- Method overloading: Method overloading allows you to define multiple methods with the same name but different parameters in the same class. The method to be called is determined at compile time based on the method signature. Method overloading is often referred to as _compile-time polymorphism_.
- Method overriding: Method overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class. The method to be called is determined at runtime based on the actual type of the object. Method overriding is an example of _runtime polymorphism_.

#### Dependency injection:

Dependency Injection: allows a class to depend on an abstract interface rather than a specific implementation... the constructor (`public Library(IBorrowable item)`) is where the dependency is provided. The constructor allows the Library class to work with any compatible implementation, such as BorrowableBook or BorrowableDVD, without needing to change its internal structure

By using Dependency Injection, the Library class can work with any implementation of IBorrowable. This approach provides:

- Flexibility: You can easily switch or add new implementations without modifying the Library class.
- Testability: You can "plug in" mock implementations for testing purposes.
- Maintainability: The Library class doesn’t need to know the details of the specific implementation, making it easier to extend and maintain.

Dependency injection ensures that dependencies are provided in a modular and testable manner

> I don't understand this concept AT ALL!

<span aria-hidden="true"><br></span>

## Miscellaneous notes

 <!-- Add code blocks through out the page -->

- Use File-Scoped Namespaces (`namespace Name;`)
- The Entry Point (`Program.cs`): Use Top-Level Statements (No namespace, no class, no Main) so `using NamespaceName`
- `IComparable`: Used for comparing objects.
- **`IEnumerable`**: Used for iterating over collections.
- `IDisposable`: Used for releasing unmanaged resources.
- `IEquatable`: Used for defining equality comparisons.

<span aria-hidden="true"><br></span>

## Code blocks

Interfaces:

```cs
// Interface
public interface IName {}

// Implement an interface:
public class ClassName : IName {}

```

Inheritance:

```cs
class DerivedClass : BaseClass {}

// virtual and override
public virtual string MethodName() {}
public override string MethodName() {}

// Note the type = BaseClass but instance of DerivedClass
// THIS IS polymorphism:
BaseClass VariableName = new DerivedClass();

// The MemberName can be a property, method, or field of the base class
base.MemberName

// Why 'abstract' here?
public abstract class BaseClass
{
    public abstract string Property1 { get; set; }
    public virtual string Property2 { get; set; } = "Base - Property2";

    public abstract void Method1();

    public void Method2()
    {
        Console.WriteLine("Base - Method2");
    }
}

public class DerivedClass : BaseClass
{
    public override string Property1 { get; set; } = "Derived - Property1";
    public new string Property2 { get; set; } = "Derived - Property2";

    public override void Method1()
    {
        Console.WriteLine("Derived - Method1");
    }

    public new void Method2()
    {
        Console.WriteLine("Derived - Method2");
    }
}

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


// ABSTRACT CLASS AND METHOD
public abstract class Shape
{
    public abstract int GetArea();
}

// Since the parent (Shape) isn't holding any data, the child (Square) must create its own field (_side) to do the work.
public class Square : Shape
{
    private int _side;

    public Square(int side)
    {
        _side = side;
    }

    public override int GetArea()
    {
        return _side * _side;
    }
}

// in Program.js
Square square = new Square(5);
Console.WriteLine($"Area of the square = {square.GetArea()}");]
```

```sh
# This is a quick way to create files
echo "namespace NamespaceName;" > FileName1.cs
```

Interfaces I am working on:

```cs
namespace InventorySystem;
// The "Transaction" attributes (OrderQty, Date).
public interface IPurchaseOrder
{
    string VendorID  { get; }
    string ItemID { get; }
    int OrderQuantity { get; set; }
    double ItemCost { get; set; }
    DateTime OrderDate { get; }
}

// This needs work
namespace InventorySystem;
// The "Source" attributes (VendorID, Lead Time).
public interface ISupplyVendor
{
    string VendorID  { get; set; }
    string AvgLeadTime { get; set; }
}
```

<span aria-hidden="true"><br></span>

## Less useful keywords in my opinion

### `sealed` keyword:

The `sealed` keyword in C# is used to prevent a class or class member from being inherited or overridden. When a class is marked as `sealed`, it can't be used as a base class for other classes. When a method is marked as sealed, it can't be overridden in derived classes.

The following rules describe how the `sealed` keyword affects inheritance:

- Sealed classes: A sealed class can't be used as a base class for other classes. It prevents inheritance from the sealed class.
- Sealed methods: A sealed method can't be overridden in derived classes. It prevents further modification of the method in derived classes.
- Sealed properties: Similar to sealed methods, sealed properties can't be overridden in derived classes.

Sealed classes and methods are useful when you want to prevent further extension or modification of a class or method. They provide a way to restrict inheritance and ensure that certain members remain unchanged.

Avoid using sealed classes and methods: Sealed classes and methods can't be inherited or overridden, which limits the ability to use polymorphism. If you seal a class or method, you prevent further extension and customization. For example:

```cs
public sealed class BankAccount { } // This class can't be inherited
```

### `new` keyword:

- The `new` keyword in child class method signatures: used to hide base class members or to avoid accidental overriding of base class members. (Not often used)
- I think you would use it when you members with the same name in both classes
- Hiding base class members using `new` in child method signatures
  - `public new void SameNameAsParentMethod()`
  - Similar to method overriding - DON'T DO THAT - use `override`!

<!-- The local repo folder name is: InventorySystem -->
