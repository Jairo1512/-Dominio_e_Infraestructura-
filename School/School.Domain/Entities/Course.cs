namespace School.Domain.Entities;

public class Course : Core.BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public int Credits { get; set; }
}
