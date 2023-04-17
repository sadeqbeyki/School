using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models
{
    public class ExamType:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
