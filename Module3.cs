using System;

namespace Module3Discussion
{
    // Class definition representing an item or entity
    public class Product
    {
        // Auto-implemented properties
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        // Parameterized Constructor
        public Product(string name, double unitPrice, int quantity)
        {
            Name = name;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        // Method calculating total before tax
        public double CalculateSubtotal()
        {
            return UnitPrice * Quantity;
        }

        // Method calculating sales tax
        public double CalculateTax(double taxRate)
        {
            return CalculateSubtotal() * taxRate;
        }

        // Method calculating grand total
        public double CalculateTotal(double taxRate)
        {
            return CalculateSubtotal() + CalculateTax(taxRate);
        }

        // Method to display formatted order details
        public void DisplaySummary(double taxRate)
        {
            Console.WriteLine("\n--- Order Summary ---");
            Console.WriteLine("Item:             {0}", Name);
            Console.WriteLine("Unit Price:       {0:C}", UnitPrice);
            Console.WriteLine("Quantity:         {0}", Quantity);
            Console.WriteLine("Subtotal:         {0:C}", CalculateSubtotal());
            Console.WriteLine("Tax ({0:P0}):        {1:C}", taxRate, CalculateTax(taxRate));
            Console.WriteLine("---------------------");
            Console.WriteLine("Total Amount:     {0:C}", CalculateTotal(taxRate));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const double StandardTaxRate = 0.07; // 7% standard rate

            Console.WriteLine("=== Product Entry Console ===");

            // Prompting for user input
            Console.Write("Enter product name: ");
            string prodName = Console.ReadLine();

            Console.Write("Enter unit price: ");
            double prodPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int prodQty = int.Parse(Console.ReadLine());

            // Instantiating an object of the Product class
            Product myProduct = new Product(prodName, prodPrice, prodQty);

            // Calling class methods to display formatted output
            myProduct.DisplaySummary(StandardTaxRate);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}