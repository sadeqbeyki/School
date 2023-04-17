using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models
{
    public class Exam : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int ExamTypeId { get; set; }
    }
}
