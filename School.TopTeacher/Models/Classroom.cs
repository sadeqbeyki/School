using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models
{
    public class Classroom : BaseEntity
    {
        public string Section { get; set; }
        public int GradeId { get; set; }
        public int TeacherId { get; set; }
    }
}
