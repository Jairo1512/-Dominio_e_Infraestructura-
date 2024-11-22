using School.Domain.Core;

namespace School.Domain.Entities;

public class Instructor : Person
{
    public string EmployeeNumber { get; set; } = string.Empty;
}

