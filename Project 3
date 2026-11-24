using System;

// This is the base Contractor class for our group project.
// It stores the basic information that every contractor
// and subcontractor will have.
public class Contractor
{
    // These private fields store the contractor's information.
    // Keeping them private prevents other classes from
    // changing the values directly.
    private string contractorName;
    private string contractorNumber;
    private DateTime contractorStartDate;

    // Default constructor.
    // This allows us to create a Contractor object
    // without providing information right away.
    public Contractor()
    {
        contractorName = "";
        contractorNumber = "";
        contractorStartDate = DateTime.Today;
    }

    // Constructor that accepts the contractor's information.
    // This allows us to set all three values when
    // creating a new Contractor object.
    public Contractor(string name, string number, DateTime startDate)
    {
        contractorName = name;
        contractorNumber = number;
        contractorStartDate = startDate;
    }

    // Getter for the contractor's name.
    public string GetContractorName()
    {
        return contractorName;
    }

    // Setter for the contractor's name.
    public void SetContractorName(string name)
    {
        contractorName = name;
    }

    // Getter for the contractor's number.
    public string GetContractorNumber()
    {
        return contractorNumber;
    }

    // Setter for the contractor's number.
    public void SetContractorNumber(string number)
    {
        contractorNumber = number;
    }

    // Getter for the contractor's start date.
    public DateTime GetContractorStartDate()
    {
        return contractorStartDate;
    }

    // Setter for the contractor's start date.
    public void SetContractorStartDate(DateTime startDate)
    {
        contractorStartDate = startDate;
    }
}
