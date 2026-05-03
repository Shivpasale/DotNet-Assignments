namespace AccessLibrary
{
    public class AccessModifiersDemo
    {
        // Public - accessible everywhere
        public string publicVar = "Public";

        // Private - only inside same class
        private string privateVar = "Private";

        // Internal - only inside same project (assembly)
        internal string internalVar = "Internal";

        // Protected - only in same class + derived class
        protected string protectedVar = "Protected";

        // Protected Internal - same assembly OR derived class
        protected internal string protectedInternalVar = "Protected Internal";

        // Method to show private access
        public void ShowPrivate()
        {
            System.Console.WriteLine(privateVar);
        }
    }
}