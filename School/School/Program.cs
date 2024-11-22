
using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Context;
using School.Infrastructure.Repositories;
using School.Domain.Repositories;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

var app = builder.Build();


app.MapGet("/courses", async (ICourseRepository courseRepo) =>
{
    return await courseRepo.GetAllCoursesAsync();
});

app.MapGet("/departments", async (IDepartmentRepository departmentRepo) =>
{
    return await departmentRepo.GetAllDepartmentsAsync();
});

app.Run();


