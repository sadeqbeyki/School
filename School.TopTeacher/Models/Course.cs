using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        //public string Duration { get; set; }
        //public string Description { get; set; }

        public ICollection<CourseSubject> CourseSubjects { get; set; }
    }
}
