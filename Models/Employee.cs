namespace EmployeeApp.Models;

/// <summary>Represents an employee record.</summary>
public sealed record Employee(
    int    Id,
    string FirstName,
    string LastName,
    string Email,
    string Department,
    string JobTitle,
    decimal Salary,
    DateOnly HireDate
)
{
    /// <summary>Full display name derived from first + last.</summary>
    public string FullName => $"{FirstName} {LastName}";
}
