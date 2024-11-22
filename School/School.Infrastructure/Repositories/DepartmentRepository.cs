using School.Domain.Entities;
using School.Infrastructure.Core;

namespace School.Infrastructure.Repositories;

public class DepartmentRepository : BaseRepository<Department>
{
    public DepartmentRepository(Context.SchoolContext context) : base(context) { }
}

