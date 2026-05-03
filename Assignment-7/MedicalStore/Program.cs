using System;
using System.Collections.Generic;

class Medicine
{
    public string Name;
    public int Qty;
    public double Rate;

    public double Amount()
    {
        return Qty * Rate;
    }
}

class Program
{
    static void Main()
    {
        List<Medicine> list = new List<Medicine>();

        Console.WriteLine("Enter Number Of Medicines:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Medicine m = new Medicine();

            Console.Write("\nEnter Medicine Name: ");
            m.Name = Console.ReadLine();

            Console.Write("Enter Rate: ");
            m.Rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            m.Qty = int.Parse(Console.ReadLine());

            list.Add(m);
        }

        // BILL PRINT
        Console.WriteLine("\n==========================================");
        Console.WriteLine("           SAI MEDICAL STORE            ");
        Console.WriteLine("==========================================");
        Console.WriteLine("{0,-15}{1,8}{2,8}{3,10}", "Medicine", "Rate", "Qty", "Amount");
        Console.WriteLine("------------------------------------------");

        double subtotal = 0;

        foreach (var m in list)
        {
            double amt = m.Amount();
            subtotal += amt;

            Console.WriteLine("{0,-15}{1,8}{2,8}{3,10}", m.Name, m.Rate, m.Qty, amt);
        }

        double gst = subtotal * 0.05;
        double grand = subtotal + gst;

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("{0,-25}{1,10}", "Subtotal: ", subtotal);
        Console.WriteLine("{0,-25}{1,10}", "GST (5%): ", gst);
        Console.WriteLine("{0,-25}{1,10}", "Grand Total: ", grand);
        Console.WriteLine("==========================================");
        Console.WriteLine("      THANK YOU...! VISIT AGAIN...!!         ");
        Console.WriteLine("==========================================");
    }
}