using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public string PersonnelNumber { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
