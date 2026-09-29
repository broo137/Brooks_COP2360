using System;

// Base class modeled directly from Classes.txt:
// Readonly immutable field
// Automatic properties
// Expression-bodied read-only calculated property
public class Stock
{
    public readonly string Symbol;
    public decimal CurrentPrice { get; set; }
    public decimal SharesOwned { get; set; }

    public Stock(string symbol, decimal currentPrice, decimal sharesOwned)
    {
        Symbol = symbol;
        CurrentPrice = currentPrice;
        SharesOwned = sharesOwned;
    }

    // Expression-bodied calculated property
    public decimal TotalValue => CurrentPrice * SharesOwned;

    public void DisplaySummary() =>
        Console.WriteLine($"[{Symbol}] Shares: {SharesOwned}, Price: {CurrentPrice:C}, Total: {TotalValue:C}");
}

// Derived class demonstrating direct Inheritance and Constructor Chaining:
// Inherits state and properties directly from Stock
// Passes core parameters up via base(...)
// Extends functionality by adding dividend-specific metrics 
public class DividendStock : Stock
{
    public decimal AnnualDividendPerShare { get; set; }

    public DividendStock(string symbol, decimal currentPrice, decimal sharesOwned, decimal annualDividend)
        : base(symbol, currentPrice, sharesOwned)
    {
        AnnualDividendPerShare = annualDividend;
    }

    // Calculated property specific to DividendStock
    public decimal ProjectedAnnualIncome => AnnualDividendPerShare * SharesOwned;

    public void DisplayDividendBreakdown()
    {
        DisplaySummary();
        Console.WriteLine($"  -> Annual Dividend/Share: {AnnualDividendPerShare:C} | Projected Income: {ProjectedAnnualIncome:C}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiating the derived class directly as a DividendStock instance
        DividendStock investment = new DividendStock("VCTR", 38.50m, 120m, 1.40m);

        Console.WriteLine($"Created instance of: {nameof(DividendStock)}");
        investment.DisplayDividendBreakdown();
    }
}
