using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program1
{
    class Program
    {
        private static object inputValue;

        static void Main(string[] args)
        {
            // Set console encoding to support Unicode (if needed for non-English languages)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Conversion constants
            const double BYTE_TO_KB = 1024.0;
            const double BYTE_TO_MB = 1024.0 * 1024.0;
            const double BYTE_TO_GB = 1024.0 * 1024.0 * 1024.0;

            while (true)
            {
                // Display menu
                Console.WriteLine("\n=== Unit Conversion Tool ===");
                Console.WriteLine("1. Convert Bytes to GB, MB, and KB");
                Console.WriteLine("2. Convert GB to Bytes");
                Console.WriteLine("3. Convert MB to Bytes");
                Console.WriteLine("4. Convert KB to Bytes");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                // قراءة اختيار المستخدم
                int choice = int.Parse(Console.ReadLine());

                // طلب القيمة من المستخدم
                Console.Write("Enter the value to convert:: ");
                double inputValue = double.Parse(Console.ReadLine());


                // Exit if user chooses 5
                if (choice == 5)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }


                // Perform conversion based on choice
                Console.WriteLine("\n=== Conversion Results ===");
                switch (choice)
                {
                    case 1: // Convert from Bytes to GB, MB, KB
                        Console.WriteLine($"{inputValue} Bytes = {inputValue / BYTE_TO_GB:F6} GB");
                        Console.WriteLine($"{inputValue} Bytes = {inputValue / BYTE_TO_MB:F6} MB");
                        Console.WriteLine($"{inputValue} Bytes = {inputValue / BYTE_TO_KB:F6} KB");
                        break;
                    case 2: // Convert from GB to Bytes
                        Console.WriteLine($"{inputValue} GB = {inputValue * BYTE_TO_GB} Bytes");
                        break;
                    case 3: // Convert from MB to Bytes
                        Console.WriteLine($"{inputValue} MB = {inputValue * BYTE_TO_MB} Bytes");
                        break;
                    case 4: // Convert from KB to Bytes
                        Console.WriteLine($"{inputValue} KB = {inputValue * BYTE_TO_KB} Bytes");
                        break;
                }
            }
        }
    }
}
