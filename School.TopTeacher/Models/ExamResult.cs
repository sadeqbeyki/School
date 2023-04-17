using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models
{
    public class ExamResult : BaseEntity
    {
        public int CourceId { get; set; }
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public string Marks { get; set; }
    }
}
