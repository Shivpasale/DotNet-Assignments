using System;

namespace AccessLibrary
{
    public class DerivedClass : AccessModifiersDemo
    {
        public void ShowAccess()
        {
            Console.WriteLine(publicVar);
            // Console.WriteLine(privateVar);        Not accessible
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(protectedInternalVar);
        }
    }
}