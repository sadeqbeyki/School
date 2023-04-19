using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string PersonnelNumber { get; set; } = string.Empty;
        public List<TeacherSubject> TeacherSubjects { get; set; }=new List<TeacherSubject>();
    }
}
