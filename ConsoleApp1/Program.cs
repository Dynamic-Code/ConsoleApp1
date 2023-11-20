using System;

public class A {
    public A()
    {
        Console.WriteLine("A");
    }
}

public class B:A
{
    public B()
    {
        Console.WriteLine("B");
    }
}
public class Exe
{
    public static void Main(string[] args)
    {
        A obj1 = new A();
        // Print A, This is allowed due to polymorphism; a derived class instance can be assigned to a base class reference.

        //  B obj2 = new A();
        // Error, You are trying to instantiate an object of type A and assign it to a variable of type B. Direct assignment of a base class instance to a derived class reference is not allowed without explicit casting.

        // A obj3 = (B)new A();
        //This is allowed, but at runtime, it may throw an InvalidCastException if the actual object is not an instance of B (or a derived type).
        // This type of casting is risky, and you should ensure the compatibility of types at runtime to avoid exceptions.

        A obj = new A();
        B? objasB = obj as B;
    
    }
}

