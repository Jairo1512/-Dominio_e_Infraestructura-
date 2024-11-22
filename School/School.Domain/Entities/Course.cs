﻿
namespace School.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
