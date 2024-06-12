using ConsoleApp1;
using System;

namespace eCommerceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new product instance
            var product = new Product(1, "Example Product", 99.99m, 50);

            // Demonstrate increasing stock
            Console.WriteLine($"Increasing stock by 10 units...");
            product.Inc_Stock(10);
            Console.WriteLine($"Current stock: {product.Stock}");

            // Demonstrate decreasing stock
            Console.WriteLine($"Decreasing stock by 20 units...");
            product.Dec_Stock(20);
            Console.WriteLine($"Current stock: {product.Stock}");

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
