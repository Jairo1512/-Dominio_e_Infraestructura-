using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace School.Infrastructure.Context;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Instructor> Instructors { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Department> Departments { get; set; } = null!;

    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

