using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public int GradeId { get; set; }
        public string Description { get; set;}
    }
}
