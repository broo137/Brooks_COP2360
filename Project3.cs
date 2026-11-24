```csharp
using System;

public class Contractor
{
    private string contractorName;
    private string contractorNumber;
    private DateTime contractorStartDate;

    public Contractor()
    {
        contractorName = "";
        contractorNumber = "";
        contractorStartDate = DateTime.Today;
    }

    public Contractor(string name, string number, DateTime startDate)
    {
        contractorName = name;
        contractorNumber = number;
        contractorStartDate = startDate;
    }

    public string GetContractorName()
    {
        return contractorName;
    }

    public void SetContractorName(string name)
    {
        contractorName = name;
    }

    public string GetContractorNumber()
    {
        return contractorNumber;
    }

    public void SetContractorNumber(string number)
    {
        contractorNumber = number;
    }

    public DateTime GetContractorStartDate()
    {
        return contractorStartDate;
    }

    public void SetContractorStartDate(DateTime startDate)
    {
        contractorStartDate = startDate;
    }
}

public class Subcontractor : Contractor
{
    public const int DayShift = 1;
    public const int NightShift = 2;

    private const double NightDifferential = 0.03;

    private int shift;
    private double hourlyPayRate;

    public Subcontractor() : base()
    {
        shift = DayShift;
        hourlyPayRate = 0.0;
    }

    public Subcontractor(
        string name,
        string number,
        DateTime startDate,
        int shift,
        double hourlyPayRate)
        : base(name, number, startDate)
    {
        SetShift(shift);
        SetHourlyPayRate(hourlyPayRate);
    }

    public int GetShift()
    {
        return shift;
    }

    public void SetShift(int newShift)
    {
        if (newShift != DayShift && newShift != NightShift)
        {
            throw new ArgumentException(
                "Shift must be 1 (day) or 2 (night).");
        }

        shift = newShift;
    }

    public double GetHourlyPayRate()
    {
        return hourlyPayRate;
    }

    public void SetHourlyPayRate(double newRate)
    {
        if (newRate < 0)
        {
            throw new ArgumentException(
                "Hourly pay rate cannot be negative.");
        }

        hourlyPayRate = newRate;
    }

    public float CalculatePay(double hoursWorked)
    {
        if (hoursWorked < 0)
        {
            throw new ArgumentException(
                "Hours worked cannot be negative.");
        }

        double pay = hoursWorked * hourlyPayRate;

        if (shift == NightShift)
        {
            pay *= 1.0 + NightDifferential;
        }

        return (float)pay;
    }
}
```
