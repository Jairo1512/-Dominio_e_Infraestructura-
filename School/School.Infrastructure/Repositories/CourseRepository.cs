using School.Domain.Entities;
using School.Infrastructure.Core;

namespace School.Infrastructure.Repositories;

public class CourseRepository : BaseRepository<Course>
{
    public CourseRepository(Context.SchoolContext context) : base(context) { }
}

