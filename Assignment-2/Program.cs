using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("1. Even/Odd");
            Console.WriteLine("2. Factorial");
            Console.WriteLine("3. Prime Check");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice input");
                return;
            }

            Console.Write("Enter number: ");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Invalid number input");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine(EvenOdd.Check(num));
                    break;

                case 2:
                    Console.WriteLine(Factorial.Calculate(num));
                    break;

                case 3:
                    Console.WriteLine(Prime.IsPrime(num) ? "Prime" : "Not Prime");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}