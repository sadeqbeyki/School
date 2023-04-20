using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models
{
    public class Teacher : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string PersonnelNumber { get; set; } = string.Empty;
        public List<TeacherSubject> TeacherSubjects { get; set; }=new List<TeacherSubject>();
        //new
        //public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
