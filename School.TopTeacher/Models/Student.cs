using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
