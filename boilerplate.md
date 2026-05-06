# Boilerplate code blocks

**Undertand the following exercise**: https://microsoftlearning.github.io/mslearn-develop-oop-csharp/Instructions/Labs/l2p2-lp3-m1-exercise-implement-base-derived-classes.html

Inheritance

```cs
// in BaseClass.cs
public class BaseClass
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

// in DerivedClass.cs
public class DerivedClass : BaseClass
{
    public int EmployeeId { get; set; }
    public decimal Salary { get; set; }
}
```

**Example of polymorphic behavior in action**: Create a list of BaseClass objects and add instances of classes that inherit BaseClass and then call methods in BaseClass.

```cs
// In Program.cs
BaseClass baseClass = new BaseClass();
DerivedClass derivedClass = new DerivedClass();

// This is odd: instantiate an object as a BaseClass type and then assign the object a DerivedClass instance
BaseClass baseClassReferencingDerivedClass = new DerivedClass();
// Method1() exists in BaseClass
// Method2() exits only in DerivedClass

baseClassReferencingDerivedClass.Method1();
// baseClassReferencingDerivedClass.Method2();
// Generates error: 'BaseClass' doesn't contain a definition for 'Method2'
```

Interfaces:

```cs
// in IMyInterface.cs
public interface IMyInterface
{
    public string SomeString { get; set; }
    public int SomeNumber { get; set; }
    public int SomethingElse { get; }

    string DisplayInfo();
}

// in SomeClass.cs
public class SomeClass : IMyInterface
{
    // You must implement everything the interface asked for
    public string SomeString { get; set; }
    public int SomeNumber { get; set; }
    public int SomethingElse { get; }

    // Constructor
    public SomeClass(string someString, int SomeNumber, int SomethingElse)
    {
        SomeString = someString;
        SomeNumber = someNumber;
        SomethingElse = somethingElse;
    }

    // Interface method implementation
    public override string DisplayInfo()
    {
        return $"{SomeString}, {SomeNumber}, {SomethingElse}";
    }
}

// In Program.cs
IMyInterface object1 = new SomeClass("word", 1, 2);

// The MS Learn example once again shows an array of objects,
// and then looping through it to demonstrate polymorphism
```

Miscellaneous:

```cs
// Calling the base class constructor from the derived class constructor
public Derived(int num) : base(param1, param2)
{
  // you need param1 & param2 initialized for this code block
}
```

## Takeaway from code in Implement polymorphism in a C# app

```cs
/*  interfaces -> use of:
    1. 'public' for interface,
    2. 'void' (or other) as method return type
*/
public interface InterfaceName {}

/*  class -> use of:
    1. 'public' for class, constructor, and methods,
    2. 'void' (or other) as method return type
*/
public class ClassName : InterfaceName {}

// In Program.cs
InterfaceName varName = new ClassName("arg1", "arg2");
varName.MethodName();
```
