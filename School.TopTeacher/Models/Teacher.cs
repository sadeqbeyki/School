using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models
{
    public class Teacher : BaseEntity
    {
        public string FullName { get; set; }
        public string Sex { get; set; }
        public int PhoneNumber { get; set; }
    }
}
