using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("1. Character Occurrence ");
            Console.WriteLine("2. Reverse Each Word ");
            Console.WriteLine("3. Remove Duplicate Characters ");
            Console.WriteLine("4. Remove Duplicate Elements ");
            Console.WriteLine("5. All Substrings ");
            Console.WriteLine("6. Exit");
            Console.WriteLine("\n================================");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: CharOccurrence(); break;
                case 2: ReverseEachWord(); break;
                case 3: RemoveDuplicateChars(); break;
                case 4: RemoveDuplicateArray(); break;
                case 5: AllSubstrings(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }

    // 1. Character Occurrence 
    static void CharOccurrence()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            int count = 0;
            bool visited = false;

            for (int k = 0; k < i; k++)
            {
                if (str[i] == str[k])
                {
                    visited = true;
                    break;
                }
            }

            if (visited) continue;

            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j])
                    count++;
            }

            Console.WriteLine(str[i] + " = " + count);
        }
    }

    // 2. Reverse Each Word 
    static void ReverseEachWord()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        string[] words = str.Split(' ');

        foreach (string word in words)
        {
            char[] arr = word.ToCharArray();

            int start = 0, end = arr.Length - 1;

            while (start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            Console.Write(new string(arr) + " ");
        }
        Console.WriteLine();
    }

    // 3. Remove Duplicate Characters 
    static void RemoveDuplicateChars()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < result.Length; j++)
            {
                if (str[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
                result += str[i];
        }

        Console.WriteLine("Result: " + result);
    }

    // 4. Remove Duplicate Elements 
    static void RemoveDuplicateArray()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Unique Array: ");

        for (int i = 0; i < n; i++)
        {
            bool duplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    duplicate = true;
                    break;
                }
            }

            if (!duplicate)
                Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    // 5. Find All Substrings 
    static void AllSubstrings()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            string temp = "";

            for (int j = i; j < str.Length; j++)
            {
                temp += str[j];
                Console.WriteLine(temp);
            }
        }
    }
}