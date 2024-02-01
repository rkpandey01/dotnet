

Console.WriteLine("Single Responsibility Principle (SRP)");
//A class should have only one reason to change, meaning it should have only one responsibility.
//Each class or module should encapsulate a single responsibility or functionality.


// Not following SRP
/*
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public void Save()
    {
        // Save employee to the database
    }

    public void GenerateReport()
    {
        // Generate employee report
    }
}
*/

// Following SRP
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

public class EmployeeDatabase
{
    public void Save(Employee employee)
    {
        // Save employee to the database
    }
}

public class ReportGenerator
{
    public void GenerateReport(Employee employee)
    {
        // Generate employee report
    }
}
