using System;
using AccessLibrary;

class Program
{
    static void Main()
    {
        AccessModifiersDemo obj = new AccessModifiersDemo();

        Console.WriteLine(obj.publicVar);
        // Console.WriteLine(obj.privateVar);
        // Console.WriteLine(obj.internalVar);  (different project)
        // Console.WriteLine(obj.protectedVar);
        // Console.WriteLine(obj.protectedInternalVar);

        obj.ShowPrivate(); // Accessing private via method

        DerivedClass d = new DerivedClass();
        d.ShowAccess();
    }
}