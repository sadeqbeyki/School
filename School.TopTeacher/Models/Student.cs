using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string NationalCode { get; set; } = string.Empty;
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
