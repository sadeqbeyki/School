using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public float Year { get; set; }
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<CourseSubject> CourseSubjects { get; set; } = new List<CourseSubject>();
    }
}
