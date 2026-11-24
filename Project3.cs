using System;

// Base class for a contractor.
// Stores information that is shared by every contractor subtype.
public class Contractor
{
    // The contractor's display name.
    private string contractorName;

    // The contractor's identification or employee number.
    private string contractorNumber;

    // The date the contractor began working.
    private DateTime contractorStartDate;

    // Default constructor.
    // Creates a contractor with blank text fields and today's date.
    // It is useful when data is assigned later through setter methods.
    public Contractor()
    {
        contractorName = "";
        contractorNumber = "";
        contractorStartDate = DateTime.Today;
    }

    // Parameterized constructor.
    // Initializes all base contractor fields at the moment of creation.
    public Contractor(string name, string number, DateTime startDate)
    {
        contractorName = name;
        contractorNumber = number;
        contractorStartDate = startDate;
    }

    // Returns the stored contractor name.
    public string GetContractorName()
    {
        return contractorName;
    }

    // Updates the contractor name.
    public void SetContractorName(string name)
    {
        contractorName = name;
    }

    // Returns the contractor number.
    public string GetContractorNumber()
    {
        return contractorNumber;
    }

    // Updates the contractor number.
    public void SetContractorNumber(string number)
    {
        contractorNumber = number;
    }

    // Returns the contractor's start date.
    public DateTime GetContractorStartDate()
    {
        return contractorStartDate;
    }

    // Updates the contractor's start date.
    public void SetContractorStartDate(DateTime startDate)
    {
        contractorStartDate = startDate;
    }
}

// Derived class representing a subcontractor.
// Subcontractor inherits name, number, and start date from Contractor.
// It additionally stores shift and hourly pay information.
public class Subcontractor : Contractor
{
    // Shift constants prevent the use of arbitrary shift values.
    // 1 represents the day shift, and 2 represents the night shift.
    public const int DayShift = 1;
    public const int NightShift = 2;

    // Night-shift workers receive a 3% pay differential.
    private const double NightDifferential = 0.03;

    // 1 = day shift; 2 = night shift.
    private int shift;

    // The subcontractor's regular hourly pay rate.
    private double hourlyPayRate;

    // Default constructor.
    // Calls Contractor's default constructor and initializes this
    // class to day shift with a zero hourly pay rate.
    public Subcontractor() : base()
    {
        shift = DayShift;
        hourlyPayRate = 0.0;
    }

    // Parameterized constructor.
    // The first three values are passed to the base Contractor constructor.
    // SetShift and SetHourlyPayRate perform validation for the extra fields.
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

    // Returns the shift code assigned to this subcontractor.
    public int GetShift()
    {
        return shift;
    }

    // Validates and changes the shift.
    // Only DayShift (1) or NightShift (2) is accepted.
    // An ArgumentException is thrown for any other value.
    public void SetShift(int newShift)
    {
        if (newShift != DayShift && newShift != NightShift)
        {
            throw new ArgumentException(
                "Shift must be 1 (day) or 2 (night).",
                nameof(newShift));
        }

        shift = newShift;
    }

    // Returns the subcontractor's regular hourly pay rate.
    public double GetHourlyPayRate()
    {
        return hourlyPayRate;
    }

    // Validates and changes the hourly pay rate.
    // Negative pay rates are invalid.
    public void SetHourlyPayRate(double newRate)
    {
        if (newRate < 0)
        {
            throw new ArgumentException(
                "Hourly pay rate cannot be negative.",
                nameof(newRate));
        }

        hourlyPayRate = newRate;
    }

    // Calculates the subcontractor's pay for the hours worked.
    // Formula: hours worked × hourly rate.
    // Night-shift workers also receive a 3% shift differential:
    // regular pay × 1.03.
    // Hours worked cannot be negative.
    public float CalculatePay(double hoursWorked)
    {
        if (hoursWorked < 0)
        {
            throw new ArgumentException(
                "Hours worked cannot be negative.",
                nameof(hoursWorked));
        }

        double pay = hoursWorked * hourlyPayRate;

        if (shift == NightShift)
        {
            pay *= 1.0 + NightDifferential;
        }

        // The result is converted from double to float because
        // the assignment requires CalculatePay to return a float.
        return (float)pay;
    }
}
```
}
```
