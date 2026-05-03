using System;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("         LINQ PRACTICE");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Filtering");
            Console.WriteLine("2. Projection");
            Console.WriteLine("3. Sorting");
            Console.WriteLine("4. Paging");
            Console.WriteLine("5. Aggregates");
            Console.WriteLine("6. Quantifiers");
            Console.WriteLine("7. Element Operators");
            Console.WriteLine("8. Grouping");
            Console.WriteLine("9. Dictionary / Lookup");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=================================");

            Console.Write("Enter Your Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("----- FILTERING PROGRAM -----");
                    FilteringDemo.Run();
                    break;

                case 2:
                    Console.WriteLine("----- PROJECTION PROGRAM -----");
                    ProjectionDemo.Run();
                    break;

                case 3:
                    Console.WriteLine("----- SORTING PROGRAM -----");
                    SortingDemo.Run();
                    break;

                case 4:
                    Console.WriteLine("----- PAGING PROGRAM -----");
                    PagingDemo.Run();
                    break;

                case 5:
                    Console.WriteLine("----- AGGREGATES PROGRAM -----");
                    AggregatesDemo.Run();
                    break;

                case 6:
                    Console.WriteLine("----- QUANTIFIERS PROGRAM -----");
                    QuantifiersDemo.Run();
                    break;

                case 7:
                    Console.WriteLine("----- ELEMENT OPERATORS PROGRAM -----");
                    ElementDemo.Run();
                    break;

                case 8:
                    Console.WriteLine("----- GROUPING PROGRAM -----");
                    GroupingDemo.Run();
                    break;

                case 9:
                    Console.WriteLine("----- DICTIONARY / LOOKUP PROGRAM -----");
                    DictionaryDemo.Run();
                    break;

                case 0:
                    Console.WriteLine("Exiting Program...");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue...");
                Console.ReadKey();
            }
        }
    }
}